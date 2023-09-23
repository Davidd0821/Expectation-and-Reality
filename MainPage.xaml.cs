namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ChangeImageButton1_Click(object sender, System.EventArgs e)
        {
            ImgBtn1.Source = "new_img1.png";
            Label1.Text = "Reality";
        }

        private void ChangeImageButton2_Click(object sender, System.EventArgs e) 
        {
            ImgBtn2.Source = "new_img2.png";
            Label2.Text = "Reality";
        }
        }
    }
