public void CallFormFromAssembely(string path,string formName)
{
        Assembly asm = Assembly.LoadFrom(path);

        foreach (Type type in asm.GetExportedTypes())
        {
            if (type.Name == formName)
            {
                var w = Activator.CreateInstance(type);
                try
                {

                    (w as Window).ShowDialog();
                }
                catch (Exception ex)
                {
                    string s = ex.Message;

                    (w as Window).ShowDialog();
                }
            }

        }
}