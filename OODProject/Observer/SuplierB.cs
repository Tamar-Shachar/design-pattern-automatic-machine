namespace OODProject.Observer;

internal class SuplierB : ISuplier
{
    public void Update(IItem item) 
    {
        if (item.GetAmount() < 5)
        {
            Form form1 = Application.OpenForms["Form1"];

            Label label = new Label();
            label.Text = $"{item.GetType()} is out of stock.\n It's suplier take care for it:)";
            label.Size = new Size(800, 50);
            label.Location = new Point(0, 0);
            label.Font = new Font("Arial", 16, FontStyle.Bold);
            form1.Controls.Add(label);
        }
    }
}
