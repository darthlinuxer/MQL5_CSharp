using System.Reflection;

namespace GuiMT_Net6;

public static class MQL5CSharp
{
    public static List<double> values = new List<double>();
    public static string msgBack = "";
    public static DLLEvents lastEvent = DLLEvents.none;
    private static Form1 form;

    public static int ReadLastEvent()
    {
        DLLEvents temp = lastEvent;
        lastEvent = DLLEvents.none;
        return (int)temp;
    }

    public static string ReadInternalMsg() => msgBack;

    public static void Load(double[] x)
    {
        values.Clear();
        foreach (double a in x) { values.Add(a); }
        msgBack = "Loaded values: " + String.Join(";", values);
        if (form != null) form.LoadValues(); //Form1 has a public method to load the values in the graph
        lastEvent = DLLEvents.valuesLoaded;
    }

    public static void ShowForm(string formName)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type[] types = assembly.GetTypes();
        foreach (Type type in types)
        {
            if (type.BaseType == typeof(Form) && type.Name == formName)
            {
                object obj_form = type.Assembly.CreateInstance(type.FullName);
                form = (Form1)obj_form;
                Thread thread = new Thread(() => Application.Run(form));
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                Thread.Sleep(200);
            }
        }
    }

    public static float Sum(float[] x) => x.Sum();

    public static float Average(float[] x) => x.Average();

    public static float Max(float[] x) => x.Max();

    public static float Min(float[] x) => x.Min();

    public static void GetFiboArray(ref long[] res, int size)
    //to update an array back to MT5, add the ref keyword to indicate that the array is passed by reference
    {
        res[0] = 0;
        res[1] = 1;
        if (size < 3) return;
        for (int i = 2; i < size; i++)
            res[i] = res[i - 1] + res[i - 2];
    }

    public static string ReplaceString(string str, string a, string b) => str.Replace(a, b);
}