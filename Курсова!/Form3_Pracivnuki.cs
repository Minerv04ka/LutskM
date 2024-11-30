using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Курсова_
{
	public partial class Form3_Pracivnuki : Form
	{
		
		public Form3_Pracivnuki()
		{
			InitializeComponent();
		}


		private void Form3_Pracivnuki_Load(object sender, EventArgs e)
		{

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Pracivnuki". При необходимости она может быть перемещена или удалена.
            this.pracivnukiTableAdapter.Fill(this.dataBaseDataSet.Pracivnuki);

		}


		private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowUserGuide();
		}


		private void ShowUserGuide()
		{
			string userGuide = "Методичка по використанню програми:\n\n" +
							   "Програма \"MinervaShop\" надає можливість додавання,видалення та оновлення інформації про користувачів у базу даних.\n" +
							   "Щоб додати інформацію про користувача, ви можете скористатися наступними методами:\n\n" +
							   "1. Додавання через таблицю: Введіть дані користувача у таблицю, заповнивши відповідні рядки з даними і натиснувши кнопку \"Додати\".\n\n" +
							   "2. Видалення через таблицю: Виділіть рядок в таблиці і натисніть кнопку \"Видалити\".\n\n" +
							   "2. Обновити через таблицю: Виділіть рядок в таблиці і натисніть кнопку \"Обновити\".\n\n" +
							   "3. Навігація в програмі: Ви можете змінювати таблиці за допомогою кнопок зліва.\n\n" +
							   "Більше відомостей про використання програми можна отримати в довідці користувача.";

			MessageBox.Show(userGuide, "Методичка по використанню програми", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void guna2Button4_Click(object sender, EventArgs e)
		{
			Form2_Tovar Form3_Pracivnuki = new Form2_Tovar();

			Form3_Pracivnuki.Show();

			this.Close();
		}

		
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			Form4_3amovlenya Form3_Pracivnuki = new Form4_3amovlenya();

			Form3_Pracivnuki.Show();

			this.Close();
		}


		private void guna2Button7_Click(object sender, EventArgs e)
		{
			{

				try
				{
					// З'єднання з базою даних
					string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\source\\repos\\Курсова!\\Курсова!\\bin\\Debug\\DataBase.accdb";
					using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
					{
						// Відкриття з'єднання
						dbConnection.Open();

						// Запит до бази даних
						string query = "SELECT * FROM Pracivnuki";
						using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, dbConnection))
						{
							// Створення DataTable для зберігання результатів запиту
							DataTable dataTable = new DataTable();

							// Заповнення DataTable даними з бази даних
							adapter.Fill(dataTable);

							// Оновлення DataGridView новими даними
							dataGridView1.DataSource = dataTable;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Помилка при оновленні даних: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		private void guna2Button2_Click(object sender, EventArgs e)
		{
			{
				if (dataGridView1.SelectedRows.Count != 1)
				{
					MessageBox.Show("Виберіть один рядок!", "Увага");
					return;
				}
				int index = dataGridView1.SelectedRows[0].Index;

				if (dataGridView1.Rows[index].Cells[0].Value == null ||
					 dataGridView1.Rows[index].Cells[1].Value == null ||
					 dataGridView1.Rows[index].Cells[2].Value == null ||
					 dataGridView1.Rows[index].Cells[3].Value == null ||
					 dataGridView1.Rows[index].Cells[4].Value == null)
				{
					MessageBox.Show("Не всі дані введені", "Увага");
					return;
				}

				string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
				string Name = dataGridView1.Rows[index].Cells[1].Value.ToString();
				string Mail = dataGridView1.Rows[index].Cells[2].Value.ToString();
				string Address = dataGridView1.Rows[index].Cells[3].Value.ToString();
				string Role = dataGridView1.Rows[index].Cells[4].Value.ToString();

				string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\source\\repos\\Курсова!\\Курсова!\\bin\\Debug\\DataBase.accdb";
				OleDbConnection dbConnection = new OleDbConnection(connectionString);

				dbConnection.Open();
				string query = "INSERT INTO Pracivnuki VALUES("
					+ id
					+ ", '"
					+ Name
					+ "', '"
					+ Mail
					+ "', '"
					+ Address
					+ "', '"
					+ Role
					+ "')";
				OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

				if (dbCommand.ExecuteNonQuery() != 1)
					MessageBox.Show("Помилка виконання!", "Помилка");
				else
					MessageBox.Show("Дані добавленні!", "Увага!");

				dbConnection.Close();

			}
		}


		private void guna2Button3_Click(object sender, EventArgs e)
		{
			{
				if (dataGridView1.SelectedRows.Count != 1)
				{
					MessageBox.Show("Виберіть один рядок!", "Увага");
					return;
				}
				int index = dataGridView1.SelectedRows[0].Index;

				if (dataGridView1.Rows[index].Cells[0].Value == null)
				{
					MessageBox.Show("Не всі дані введені", "Увага");
					return;
				}

				string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

				string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\source\\repos\\Курсова!\\Курсова!\\bin\\Debug\\DataBase.accdb";
				OleDbConnection dbConnection = new OleDbConnection(connectionString);

				dbConnection.Open();
				string query = "DELETE FROM Pracivnuki WHERE id = " + id;
				OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

				if (dbCommand.ExecuteNonQuery() != 1)
					MessageBox.Show("Помилка виконання!", "Помилка");
				else
					MessageBox.Show("Дані видаленні!", "Увага!");

				dbConnection.Close();
			}
		}


		private void guna2Button1_Click(object sender, EventArgs e)
		{
			{
				if (dataGridView1.SelectedRows.Count != 1)
				{
					MessageBox.Show("Виберіть один рядок!", "Увага");
					return;
				}
				int index = dataGridView1.SelectedRows[0].Index;

				if (dataGridView1.Rows[index].Cells[0].Value == null ||
					dataGridView1.Rows[index].Cells[1].Value == null ||
					dataGridView1.Rows[index].Cells[2].Value == null ||
					dataGridView1.Rows[index].Cells[3].Value == null ||
					dataGridView1.Rows[index].Cells[4].Value == null )

				{
					MessageBox.Show("Не всі дані введені", "Увага");
					return;
				}

				string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
				string Name = dataGridView1.Rows[index].Cells[1].Value.ToString();
				string Mail = dataGridView1.Rows[index].Cells[2].Value.ToString();
				string Address = dataGridView1.Rows[index].Cells[3].Value.ToString();
				string Role = dataGridView1.Rows[index].Cells[4].Value.ToString();

				string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\source\\repos\\Курсова!\\Курсова!\\bin\\Debug\\DataBase.accdb";
				OleDbConnection dbConnection = new OleDbConnection(connectionString);

				dbConnection.Open();
				string query = "UPDATE Pracivnuki SET Name = '"
					+ Name
					+ "', Mail = '" + Mail + "',Address = '" + Address + "',Role = '" + Role + "' WHERE id = "
					+ id;
				OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

				if (dbCommand.ExecuteNonQuery() != 1)
					MessageBox.Show("Помилка виконання!", "Помилка");
				else
					MessageBox.Show("Дані обновленні!", "Увага!");

				dbConnection.Close();

			}
		}




	}
}