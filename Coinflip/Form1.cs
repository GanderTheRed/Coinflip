namespace Coinflip
{
    //Enable us to use a sound player
    using System.Media;

    public partial class Form1 : Form
    {
        //Create a bitmap object
        Bitmap heads = new Bitmap("V:\\Derek\\ITEC140\\toonie_heads.png");
        Bitmap tails = new Bitmap("V:\\Derek\\ITEC140\\toonie_tails.png");
        SoundPlayer soundPlayer = new SoundPlayer("V:\\Derek\\ITEC140\\coinflip.wav");
        //Random variable
        Random random = new Random();

        //Int to represent coinflip result
        int Coin1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            Coin1 = random.Next(0, 2);
            switch (Coin1)
            {
                case 0:
                    picCoin.Image = heads;
                    lblResult.Text = "Heads!";
                    break;
                case 1:
                    picCoin.Image = tails;
                    lblResult.Text = "Tails!";
                    break;
            }
            soundPlayer.Play();

        }
    }
}