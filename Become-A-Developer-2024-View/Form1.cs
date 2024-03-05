using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Become_A_Developer_2024_View
{
	public partial class Form1 : Form
	{
		string filePath;
		public Form1()
		{
			InitializeComponent();
			listBox.Items.Add("Файл не вибрано");
		}
		private void OpenFileBtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Виберіть файл",
				Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string extension = Path.GetExtension(openFileDialog.FileName);

				if (extension.ToLower() == ".txt")
				{
					filePath = openFileDialog.FileName;
					listBox.Items.Clear();
					listBox.Items.Add("Вибранний файл: " + filePath);
				}
				else
				{
					MessageBox.Show("Выбран файл с неподдерживаемым расширением: " + extension);
				}
			}
		}

		private void FindValues_Btn_Click(object sender, EventArgs e)
		{
			if (File.Exists(filePath))
			{
				Stopwatch sw = new Stopwatch();
				sw.Start();

				int[] numbers = Array.ConvertAll(File.ReadAllLines(filePath), int.Parse);

				string longestIncreasingSequence = FindLongestIncreasingSequence(numbers);
				string longestOutcreasingSequence = FindLongestOutcreasingSequence(numbers);
				
				double avarageNum = FindAvarege(numbers);
				double median = FindMedian(numbers);

				sw.Stop();
				TimeSpan timeSpan = sw.Elapsed;

				listBox.Items.Clear();
				listBox.Items.Add("Час виконання програми: " + timeSpan.TotalSeconds + ".c");
				listBox.Items.Add("Мiнiмальне число: " + numbers[0]);
				listBox.Items.Add("Максимальне: " + numbers[numbers.Length - 1]);
				listBox.Items.Add("Середнє арифметичне: " + avarageNum);
				listBox.Items.Add("Медiaна: " + median);
				listBox.Items.Add("Найбiльша послiдовнiсть чисел що збiльшуються: " + longestIncreasingSequence);
				listBox.Items.Add("Найбiльша послiдовнiсть чисел що зменшуються: " + longestOutcreasingSequence);
			}
			else
			{
				MessageBox.Show("Невдалось відкрити данний файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private double FindAvarege(int[] numbers)
		{
			int sum = 0;
			foreach(int num in numbers)
				sum += num;

			return (double) sum / numbers.Length;
		}
		private double FindMedian(int[] numbers)
		{
			double median;
			Array.Sort(numbers);

			if (numbers.Length % 2 == 0)
			{
				int middleIndex1 = numbers.Length / 2 - 1;
				int middleIndex2 = numbers.Length / 2;

				median = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0d;
			}
			else
			{
				median = numbers[numbers.Length / 2];
			}

			return median;
		}
		private string FindLongestOutcreasingSequence(int[] numbers)
		{
			string longestOutcreasingSequence = null;
			int maxLength = 1;
			int currentLength = 1;
			int startIndex = 0;
			int maxLengthIndex = 0;

			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] < numbers[i - 1])
				{
					currentLength++;
					if (currentLength > maxLength)
					{
						maxLength = currentLength;
						maxLengthIndex = startIndex;
					}
				}
				else
				{
					currentLength = 1;
					startIndex = i;
				}
			}
			for (int i = 0; i < maxLength; i++)
			{
				longestOutcreasingSequence += numbers[maxLengthIndex + i] + ", ";
			}

			return longestOutcreasingSequence;
		}
		private string FindLongestIncreasingSequence(int[] numbers)
		{
			string longestIncreasingSequence = null;
			int maxLength = 1;
			int currentLength = 1;
			int startIndex = 0;
			int maxLengthIndex = 0;

			
				for (int i = 1; i < numbers.Length; i++)
				{
					if (numbers[i] > numbers[i - 1])
					{
						currentLength++;
						if (currentLength > maxLength)
						{
							maxLength = currentLength;
							maxLengthIndex = startIndex;
						}
					}
					else
					{
						currentLength = 1;
						startIndex = i;
					}
				}

			for (int i = 0; i < maxLength; i++)
			{
				longestIncreasingSequence += numbers[maxLengthIndex + i] + ", ";
			}

			return longestIncreasingSequence;
		}
	}
}
