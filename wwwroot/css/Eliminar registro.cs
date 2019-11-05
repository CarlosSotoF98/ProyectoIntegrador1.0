using System;

public class EliminarRegistro
{
	public EliminarRegistro()
	{
       // ELIMINAR REGISTRO
        
        string sqlIns = ("DELETE FROM @TABLA WHERE ID = @ID");
        db.Open();
        int ID;
        string tabla,ape,nom,admi;
        try
        {
            SqlCommand cmdIns = new SqlCommand(sqlIns, db.Connection);
            cmdIns.Parameters.Add("@ID", ID);
            cmdIns.Parameters.Add("@TABLA", tabla);
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.ToString(), ex);
        }
        finally
        {
            db.Close();
        }
    }
}
