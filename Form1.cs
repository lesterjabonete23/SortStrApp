namespace SortStrApp
{
    public partial class frm_SortStrApp : Form
    {
        private StringModel _model;
        private StringController _controller;
        public frm_SortStrApp()
        {
            InitializeComponent();
            _model = new StringModel();
            _controller = new StringController(_model);

            // Populate combobox with sorting strategies
            cbb_MVC.Items.Add("Bubble Sort");
            cbb_MVC.Items.Add("Quick Sort");
            cbb_MVC.SelectedIndex = 0;
        }
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            _model.InputString = txb_StrInput.Text;

            // Set the sorting strategy based on user selection
            switch (cbb_MVC.SelectedItem.ToString())
            {
                case "Bubble Sort":
                    _controller.SetSortingStrategy(new BubbleSort());
                    break;
                case "Quick Sort":
                    _controller.SetSortingStrategy(new Quicksort());
                    break;
            }

            // Sort the string
            _controller.SortString();

            // Display the sorted string
            lbl_Output.Text = _model.SortedString;
        }
    }
    public interface ISortingStrategy
    {
        string Sort(string input);
    }

    public class BubbleSort : ISortingStrategy
    {
        public string Sort(string input)
        {
            char[] charArray = input.ToCharArray();
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = 0; j < charArray.Length - i - 1; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                        // Swap
                        char temp = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = temp;
                    }
                }
            }
            return new string(charArray);
        }
    }
    public class Quicksort : ISortingStrategy
    {
        public string Sort(string input)
        {
            char[] charArray = input.ToCharArray();
            QuickSort(charArray, 0, charArray.Length - 1);
            return new string(charArray);
        }

        private void QuickSort(char[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        private int Partition(char[] array, int low, int high)
        {
            char pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    // Swap
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Swap
            char temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }

    public class StringModel
    {
        public string InputString { get; set; }
        public string SortedString { get; set; }
    }

    public class StringController
    {
        private StringModel _model;
        private ISortingStrategy _sortingStrategy;

        public StringController(StringModel model)
        {
            _model = model;
        }

        public void SetSortingStrategy(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public void SortString()
        {
            if (_sortingStrategy != null && !string.IsNullOrEmpty(_model.InputString))
            {
                _model.SortedString = _sortingStrategy.Sort(_model.InputString);
            }
        }
    }

}