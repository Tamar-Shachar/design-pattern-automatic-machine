namespace OODProject.Observer;

internal class SuplierA : ISuplier
{
   
    public void Update(Type type)
    {
        var result = type.GetMethod("GetAmount").Invoke(null, null);
        if (Int32.Parse(result.ToString()) < 5)
        {
            Form form1 = Application.OpenForms["Form1"];

            Label label = new Label();
            label.Text = $"{type.Name} is out of stock.\n It's suplier take care for it:)";
            label.Size = new Size(800, 50);
            label.Location = new Point(0, 0);
            label.Font = new Font("Arial", 16, FontStyle.Bold);
            form1.Controls.Add(label);
        }
    }
}
