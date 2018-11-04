  using System.Collections.Generic;
  using Library;

  class ListDemo {

    public static void Main(string[] args) {
      List<string>  strList = new List<string> ();
      for (int i = 0; i < 10; i++)
        strList.Add( IO.ReadWord() );
      IO.WriteLine(strList.Count + " items in the list");
      for (int j = strList.Count - 1; j >= 0; j--) {
        IO.Write( (strList[j]).ToUpper() );
        if (strList[j].Equals("Karen") ) IO.Write(" the rotter");
        IO.WriteLine();
      }
    }
  }
