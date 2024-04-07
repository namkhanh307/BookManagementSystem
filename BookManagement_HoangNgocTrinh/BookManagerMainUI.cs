using Repositories.Entities;
using Services;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BookManagement_HoangNgocTrinh
{
    public partial class BookManagerMainUI : Form
    {
        //backing field _

        private Book _selected = null; //chờ ai đó nhấn chọn 1 dòng trong grid/table
                                       //thì nó đc gán = cuốn sách đang chọn 
                                       //đẩy cuốn sách đc chọn sang màn hình update

        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        private void RefreshGridView()
        {
            BookService service = new BookService();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = service.GetAllBooks();
        }
        public void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            //gọi Services để cung cấp data vào grid/table
            RefreshGridView();
            //                               hàm I trả về all books
        }

        private void grbSearchCriteria_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gọi màn hình Detail lên. Màn hình này bản chất là class BookDetailFrom, khác truyền thống là nó có phần render bề mặt!!!
            //Nó 1 class nên nó sẽ có _field, prop, methods như bt
            //khai báo biến, new như bt
            //thêm phần render
            BookDetailForm f = new BookDetailForm();
            f.ShowDialog(); //render đi em 
            //f.Show(); //nguy hiểm nhen, vì cứ new là có object, cửa sổ mới!!!

        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //người dùng có thể chọn 1 dòng hay nhiều dòng - chìm chuột, cho nên ta sẽ lấy dòng đầu tiên đc chọn nếu người ta chọn nhiều dòng
            if (dgvBookList.SelectedRows.Count > 0)
            {
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn là bốc nó ra, đẩy sang màn hình detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;  //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .DataSource = List<Book> của hàm GetAllBooks()
            }
            //TODO: nếu user chọn Cell thay vì chọn nguyên dòng, reset biế _selected về null

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //đẩy sang Form Detail
            //khai biến, new, gán prop, show dialog
            //thằng form detail: mở lên, check selected khác null hem? khác null mode EDIT, SHOW DATA ĐC GỬI SANG

            if (_selected != null) //người dùng phải chọn 1 dòng trong grid
            {
                BookDetailForm f = new BookDetailForm();

                //đưa sách sang
                f.SelectedBook = _selected;

                f.BookUpdated += (s, args) =>
                {
                    // Refresh data in DataGridView
                    BookService service = new BookService();
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = service.GetAllBooks();
                };
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select a certain book to edit!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ta sẽ lấy ra 2 chuỗi đang nằm trong txtBookName & txtDescription
            //và ta where trên cái danh sách books đang có

            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;
            //dgvBookList.DataSource = books.Where(x => false).ToList(); //ko trả về cuốn nào
            //dgvBookList.DataSource = books.Where(x => true).ToList(); //đưa cuốn nào cx đồng ý hết trơn

            //dgvBookList.DataSource = books.Where(
            //    delegate (Book x)
            //    {
            //        return x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower());
            //    }
            //).ToList();

            dgvBookList.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || x.Description.ToLower().Contains(txtDescription.Text.ToLower())).ToList();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            //Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {

                DialogResult answer = MessageBox.Show("Do you really want to delete this book", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(answer == DialogResult.No)
                {
                    return;
                }
                //nếu chọn ít nhất 1 dòng, thì cứ dòng đầu tiên đc chọn là bốc nó ra, đẩy sang màn hình detail
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;  //lấy 1 dòng chính là kiểu object tổng quát, nhưng bản chất là Book do lúc đầu .DataSource = List<Book> của hàm GetAllBooks()
                BookService bookService = new();
                bookService.DeleteBook(_selected);
                //F5 lai luoi
                //FillDateGridView
                RefreshGridView();
                _selected = null;
            }
        }
    }
}
