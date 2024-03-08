 class Careers : IWebPage
    {
      protected ITheme theme;

      public Careers(ITheme theme)
      {
        this.theme = theme;
      }

      public string GetContent()
      {
        return String.Format("Careers page in {0}", theme.GetColor());
      }
    }