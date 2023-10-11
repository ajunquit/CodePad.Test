using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePad.Test;
public class Answer
{
    public void Run(Service s, Connection c)
    {
        try
        {
            s.SetConnection(c);
            s.Execute();
            c.Commit();
        }
        catch (Exception)
        {
            c.Rollback();
        }
        finally
        {
            c.Close();
        }
       
    }
}

public interface Service
{
    void Execute();
    void SetConnection(Connection c);
}
public interface Connection {
    void Commit();
    void Rollback();
    void Close();
}