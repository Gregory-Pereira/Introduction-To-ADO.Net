using System;
using System.Data.SQLClient;

class SqlConnectionProgram {
  static void Main() {
    //Windows Authentication
      //@"Data Source =(Machine Name)\(InstanceName)Initial Catalog=(DBName);Integrated Secuirty = true;"
    //SQL Authentiication
      //@"Data Source =(Machine Name)\(InstanceName)Initial Catalog=(DBName);ID=(username);Password=(Password);"

    SqlConnection SqlConnection = new SqlConnection();
    SqlConnection.open();
    SqlCommand queryOne = new SQLCommand("Select * from products", SqlConnection);
    SqlDataReader reader = queryOne.ExecuteReader();
    while (reader.Read())
    {
      Console.WriteLine(reader.GetString(0));
    }
    reader.Close();
    SqlConnection.Close();

    if(Debugger.isAttached) {
      Console.ReadLine();
    }
  }
}

