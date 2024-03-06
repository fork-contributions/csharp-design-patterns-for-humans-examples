 public class President
  {
    static President instance;
    // Private constructor
    private President()
    {
    }

    // Public constructor
    public static President getInstance()
    {
      if (instance == null) {
        instance = new President();
      }
      return instance;
    }
  }