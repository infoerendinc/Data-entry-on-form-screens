using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private TextBox textBox;
    private Button button;

    public MainForm()
    {
        InitializeComponents();

        this.Text = "Veri Girişi Formu";
        this.Width = 300;
        this.Height = 150;
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void InitializeComponents()
    {
        // Metin kutusu oluşturma ve ayarları
        textBox = new TextBox();
        textBox.Location = new System.Drawing.Point(30, 30);
        textBox.Size = new System.Drawing.Size(200, 25);

        // Buton oluşturma ve ayarları
        button = new Button();
        button.Text = "Gönder";
        button.Location = new System.Drawing.Point(100, 70);
        button.Click += Button_Click;

        // Forma kontrolleri ekleme
        this.Controls.Add(textBox);
        this.Controls.Add(button);
    }

    private void Button_Click(object sender, EventArgs e)
    {
        // Metin kutusundan veriyi alıp işleme
        string userInput = textBox.Text;
        MessageBox.Show($"Girilen metin: {userInput}");
    }

    public static void Main()
    {
        Application.Run(new MainForm());
    }
}