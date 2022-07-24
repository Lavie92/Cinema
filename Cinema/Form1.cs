namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSeats(3, 5);
        }
        private void InitSeats(int row, int col)
        {
            int x, y = 11, distance = 70, count = 1;
            for(int i = 0; i < row; i++)
            {
                x = 16;
                for(int j = 0; j < col; j++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Location = new System.Drawing.Point(x, y);
                    btnSeat.Size = new System.Drawing.Size(50, 50);
                    btnSeat.Text = count++.ToString();
                    btnSeat.BackColor = Color.White;
                    btnSeat.UseVisualStyleBackColor = true;
                    pnlSeats.Controls.Add(btnSeat);
                    btnSeat.Click += BtnSeat_Click;
                    x += distance;
                }
                y += distance;
            }
        }

        private void BtnSeat_Click(object? sender, EventArgs e)
        {
            Button btnSeat = (Button)sender;
            if (btnSeat.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã bị mua, giận hết sức o(￣┰￣*)ゞ");
                return;
            }
            if (btnSeat.BackColor == Color.White)
            {
                btnSeat.BackColor = Color.Blue;
            }
            else
            {
                btnSeat.BackColor = Color.White;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            double Total = 0;
            foreach (Button seat in pnlSeats.Controls)
            {
                if (seat.BackColor == Color.Blue)
                {
                   Total += BillCheck(seat.Text);
                   seat.BackColor = Color.Yellow;
                }
            }
            txtTotal.Text = Total.ToString();
        }
        private float BillCheck(string text) 
        {
            int numberSeat = Int32.Parse(text);
            if (numberSeat <= 5)
            {
                return 50000;
            }
            else if (numberSeat <= 10)
            {
                return 65000;
            }
            else
            {
                return 80000;
            }
            return 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Button seat in pnlSeats.Controls)
            {
                if (seat.BackColor == Color.Blue)
                {
                    seat.BackColor = Color.White;
                }
            }
            txtTotal.Text = "0";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}