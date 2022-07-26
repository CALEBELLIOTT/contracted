using System.Collections.Generic;
using System.Data;
using System.Linq;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{
  public class ContractorsRepository
  {
    private readonly IDbConnection _db;

    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Contractor> GetAll()
    {
      string Sql = @"
      SELECT * FROM contractors
      ";
      List<Contractor> contractors = _db.Query<Contractor>(Sql).ToList();
      return contractors;
    }
  }
}