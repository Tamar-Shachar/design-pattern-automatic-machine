using OODProject.Factory;
using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;
internal class Payment : BaseHandler
{
    private ManualResetEvent mre = new ManualResetEvent(false);
    public override async Task<IItem> Handel(IItem item)
    {
        double price = ((Product)item).GetPrice();
        Form form1 = Application.OpenForms["Form1"];
        Label label = new Label();
        label.Text = $"The amount to be paid is: {price}₪";
        label.Size = new Size(800, 50);
        label.Location = new Point(420, 128);
        label.Font = new Font("Arial", 16, FontStyle.Bold);
        form1.Controls.Add(label);

        TextBox amount = new TextBox();
        amount.PlaceholderText = "Enter amount";
        amount.Size = new Size(200, 100);
        amount.Location = new Point(460, 200);
        amount.Font = new Font("Arial", 12);
        form1.Controls.Add(amount);
        form1.ActiveControl = null;

        Button okButton = new Button();
        okButton.Text = "OK";
        okButton.Size = new Size(100, 30);
        okButton.Location = new Point(670, 200);
        form1.Controls.Add(okButton);
        Label label2 = new Label();
        okButton.Click += async (sender, e) =>
        {
            label2.Size = new Size(800, 50);
            label2.Location = new Point(420, 280);
            label2.Font = new Font("Arial", 12);
            int y;
            var x = Int32.TryParse(amount.Text,out y);
            if ( x == true && price <= y)
            {
                label2.Text = $"surplus: {(Int32.Parse(amount.Text)) - price}₪";
                label2.ForeColor = System.Drawing.Color.Black;
                form1.Controls.Add(label2);
                label.Enabled = false;
                amount.Enabled = false;
                okButton.Enabled = false;
                mre.Set();
            }
            else
            {
                label2.Text = "The money is not enough, please enter again";
                amount.Text = "";
                label2.ForeColor = System.Drawing.Color.Red;
                form1.Controls.Add(label2);
            }
        };

        await Task.Run(() =>
        {
            mre.WaitOne();
            mre.Reset();

        });
        
        return base.Handel(item).Result;

    }

}

