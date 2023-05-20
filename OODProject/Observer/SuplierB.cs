namespace OODProject.Observer;

internal class SuplierB : ISuplier
{
    public void Update(Type type) 
    {
        var result = type.GetMethod("GetAmount").Invoke(null, null);
        if (Int32.Parse(result.ToString()) < 5)
        {
            Form form1 = Application.OpenForms["Form1"];

            MessageBox
                .Show($"{type.Name} is out of stock.\n It's suplier take care for it:)"
                , this.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
        }
    }
}
