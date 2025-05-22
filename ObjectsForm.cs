using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace PR5
{
    public partial class ObjectsForm : Form
    {
        NpgsqlDataAdapter adapter;
        DataTable dataTable;

        public ObjectsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = new Size(this.Width + 200, this.Height);
            LoadObjects();
        }

        public void LoadObjects()
        {
            using (NpgsqlCommand command = new NpgsqlCommand("select * from объекты join статус on статус.ин = ин_статуса;", MainForm.conn))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    objectsList.Controls.Clear();
                    while (reader.Read())
                    {
                        ListBox obj = new ListBox();
                        {
                            obj.FormattingEnabled = true;
                            obj.ItemHeight = 15;
                            obj.Location = new Point(5, 5);
                            obj.Name = reader["ин"].ToString();
                            obj.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
                            obj.Size = new Size(200, 200);
                            obj.Items.AddRange(new object[] {
                                "Тип: " + reader["тип"].ToString(),
                                "Район: " + reader["район"].ToString(),
                                "Кол.комн: " + reader["кол_комн"].ToString(),
                                "Плодащь: " + reader["площадь"].ToString(),
                                "Год: " + reader["год"].ToString(),
                                "Адрес: " + reader["адрес"].ToString(),
                                "Цена: " + reader["цена"].ToString(),
                                "Статус: " + reader["наим"].ToString()
                            });
                            obj.Click += Obj_Click;
                        }
                        objectsList.Controls.Add(obj);
                    }
                }
            }
        }

        private void Obj_Click(object? sender, EventArgs e)
        {
            objectsList.Visible = false;
            editGrid.Visible = true;
            saveBtn.Visible = true;
            
            ListBox listBox = sender as ListBox;
            adapter = new NpgsqlDataAdapter("select * from объекты where объекты.ин = " + listBox.Name + ";", MainForm.conn);
            dataTable = new DataTable();
            adapter.Fill(dataTable);

            editGrid.Controls.Clear();
            editGrid.DataSource = dataTable;
            editGrid.Columns["ин"].Visible = false;

            this.Width += 200;
            editGrid.Width += 200;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (editGrid.Visible)
            {
                objectsList.Visible = true;
                editGrid.Visible = false;
                saveBtn.Visible = false;
                this.Width -= 200;
                editGrid.Width -= 200;
                LoadObjects();
            }
            else
                this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(adapter);
            adapter.Update(dataTable);
            MessageBox.Show("Изменения сохранены.");
        }
    }
}
