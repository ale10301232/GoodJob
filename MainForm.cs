namespace GoodJob;

public partial class MainForm : Form
{
    GoodJobForm form = new GoodJobForm();
    public MainForm()
    {
        InitializeComponent();
        
        form.FormClosed += Form_FormClosed;
        form.StartPosition = FormStartPosition.CenterScreen;
    }

    public void button1_Click(Object state, EventArgs e)
    {
        this.Hide();
        form.ShowDialog();       
    }

    private void Form_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Visible = true;
    }
}
