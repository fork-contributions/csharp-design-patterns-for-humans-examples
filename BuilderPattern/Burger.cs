 class Burger
    {
      private int mSize;
      private bool mCheese;
      private bool mPepperoni;
      private bool mLettuce;
      private bool mTomato;

      public Burger(BurgerBuilder builder)
      {
        this.mSize = builder.Size;
        this.mCheese = builder.Cheese;
        this.mPepperoni = builder.Pepperoni;
        this.mLettuce = builder.Lettuce;
        this.mTomato = builder.Tomato;
      }
    }