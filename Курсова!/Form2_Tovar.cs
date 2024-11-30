using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Курсова_
{
	public partial class Form2_Tovar : Form
	{


		public Form2_Tovar()
		{
			InitializeComponent();
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


		private void guna2Button5_Click(object sender, EventArgs e)
		{
			Form4_3amovlenya Form3_Pracivnuki = new Form4_3amovlenya();

			Form3_Pracivnuki.Show();

			this.Close();
		}


		private void guna2Button4_Click(object sender, EventArgs e)
		{
			Form3_Pracivnuki Form2_Tovar = new Form3_Pracivnuki();

			Form2_Tovar.Show();

			this.Close();
		}


		private void Form2_Load(object sender, EventArgs e)
		{
			;
			// TODO: This line of code loads data into the 'dataBaseDataSet.Tovar' table. You can move, or remove it, as needed.
			this.tovarTableAdapter.Fill(this.dataBaseDataSet.Tovar);

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
				string Quantity = dataGridView1.Rows[index].Cells[2].Value.ToString();
				string Cost = dataGridView1.Rows[index].Cells[3].Value.ToString();
				string Firm = dataGridView1.Rows[index].Cells[4].Value.ToString();

				string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb";
				OleDbConnection dbConnection = new OleDbConnection(connectionString);

				dbConnection.Open();
				string query = "INSERT INTO Tovar VALUES("
					+ id
					+ ", '"
					+ Name
					+ "', '"
					+ Quantity
					+ "', '"
					+ Cost
					+ "', '"
					+ Firm
					+ "')";
				OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

				if (dbCommand.ExecuteNonQuery() != 1)
					MessageBox.Show("Помилка виконання!", "Помилка");
				else
					MessageBox.Show("Дані добавленні!", "Увага!");

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
					 dataGridView1.Rows[index].Cells[4].Value == null)
				{
					MessageBox.Show("Не всі дані введені", "Увага");
					return;
				}

				string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
				string Name = dataGridView1.Rows[index].Cells[1].Value.ToString();
				string Quantity = dataGridView1.Rows[index].Cells[2].Value.ToString();
				string Cost = dataGridView1.Rows[index].Cells[3].Value.ToString();
				string Firm = dataGridView1.Rows[index].Cells[3].Value.ToString();

				string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb";
				OleDbConnection dbConnection = new OleDbConnection(connectionString);

				dbConnection.Open();
				string query = "UPDATE Tovar SET Name = '"
					+ Name
					+ "', Quantity= "
					+ Quantity
					+ ", Cost = "
					+ Cost
					+ ", Firm = "
					+ Firm
					+ " WHERE id = "
					+ id;
				OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

				if (dbCommand.ExecuteNonQuery() != 1)
					MessageBox.Show("Помилка виконання!", "Помилка");
				else
					MessageBox.Show("Дані обновленні!", "Увага!");

				dbConnection.Close();

			}
		}


		private void guna2Button3_Click(object sender, EventArgs e)
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

			string ID = dataGridView1.Rows[index].Cells[0].Value.ToString();

			string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb";
			OleDbConnection dbConnection = new OleDbConnection(connectionString);

			dbConnection.Open();
			string query = "DELETE FROM Tovar WHERE ID = " + ID;
			OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

			if (dbCommand.ExecuteNonQuery() != 1)
				MessageBox.Show("Помилка виконання!", "Помилка");
			else
				MessageBox.Show("Дані видаленні!", "Увага!");

			dbConnection.Close();
		}


		private void guna2Button6_Click(object sender, EventArgs e)
		{
			try
			{
				
				string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DataBase.accdb";
				using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
				{
					
					dbConnection.Open();

			
					string query = "SELECT * FROM Tovar";
					using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, dbConnection))
					{
						
						DataTable dataTable = new DataTable();

						
						adapter.Fill(dataTable);

						
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
}

