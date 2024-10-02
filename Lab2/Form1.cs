namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            buttonSpace.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            label2.Visible = false;
            label1.Text = "Оберіть завдання, яке необхідно виконати";
            richTextBox2.ReadOnly = true;
        }

        // Завдання А: Оптимізований двійковий пошук
        private int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (target - arr[left]) * (right - left) / (arr[right] - arr[left]);

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;  // якщо не знайдено
        }

        private string RemoveExtraSpaces(string sentence)
        {
            string result = string.Join(" ", sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            
            if (!result.EndsWith("."))
            {
                result += ".";
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо масив чисел з текстового поля
                int[] array = richTextBox1.Text.Split(' ').Select(int.Parse).ToArray();
                int target = Convert.ToInt32(textBox1.Text);  // Цільове значення

                int index = BinarySearch(array, target);

                if (index != -1)
                    richTextBox2.Text = $"Елемент '{target}' знайдено на позиції: {index}";
                else
                    richTextBox2.Text = "Елемент не знайдено";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка введення даних: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZavdA_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
            richTextBox2.Text = "";
            textBox1.Visible = true;
            label3.Visible = true;
            button1.Visible = true;
            buttonSpace.Visible = false;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            label2.Visible = true;
            label1.Text = "Введіть масив чисел через пробіл:";
        }

        private void ZavdB_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            buttonSpace.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            label2.Visible = true;
            richTextBox1.Text = "";
            textBox1.Text = "";
            richTextBox2.Text = "";
            label1.Text = "Введіть речення, в якому треба прибрати зайві пробіли, з крапкою в кінці:";
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            try
            {
                string sentence = richTextBox1.Text;
                string result = RemoveExtraSpaces(sentence);
                richTextBox2.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка введення даних: " + ex.Message);
            }
        }
    }
}
