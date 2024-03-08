 class About : IWebPage
    {
      protected ITheme theme;

      public About(ITheme theme)
      {
        this.theme = theme;
      }

      public string GetContent()
      {
        return String.Format("About page in {0}", theme.GetColor());
      }
    }