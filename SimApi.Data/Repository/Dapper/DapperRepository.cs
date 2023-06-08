using Dapper;
using SimApi.Base;
using SimApi.Data.Context;
using System.Data;
using static Dapper.SqlMapper;

namespace SimApi.Data.Repository;

public class DapperRepository<Entity> : IDapperRepository<Entity> where Entity : BaseModel
{
    protected readonly SimDapperDbContext dbContext;
    private bool disposed;

    public DapperRepository(SimDapperDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public void DeleteById(int id)
    {
        using (var connection = dbContext.CreateConnection())
        {
            connection.Open();
            string query = "DELETE FROM " + typeof(Entity).Name + " WHERE Id = @Id";
            var parameter = new { Id = id };
            connection.Query<Entity>(query, parameter);
        }
    }

    public List<Entity> Filter(string sql)
    {
        throw new NotImplementedException();
    }

    public List<Entity> GetAll()
    {
        using (var connection = dbContext.CreateConnection())
        {
            connection.Open();
            var query = "SELECT * FROM " + typeof(Entity).Name;
            return connection.Query<Entity>(query).ToList();
        }
    }

    public Entity GetById(int id)
    {
        using (var connection = dbContext.CreateConnection())
        {
            connection.Open();
            var query = "SELECT * FROM " + typeof(Entity).Name + " WHERE Id = @Id";
            return connection.QuerySingleOrDefault<Entity>(query, new { Id = id });
        }
    }

    public void Insert(Entity entity)
    {
        using (var connection = dbContext.CreateConnection())
        {
            string tableName = typeof(Entity).Name;
            var properties = typeof(Entity).GetProperties().Where(p => p.Name != "Id");

            string columns = string.Join(", ", properties.Select(p => "[" + p.Name + "]"));
            string parameters = string.Join(", ", properties.Select(p => "@" + p.Name));

            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters});";

            connection.Execute(query, entity);
        }
    }

    public void Update(Entity entity)
    {
        using (var connection = dbContext.CreateConnection())
        {
            string tableName = typeof(Entity).Name;
            var properties = typeof(Entity).GetProperties().Where(p => p.Name != "Id");

            string columns = string.Join(", ", properties.Select(p => "[" + p.Name + "]"));
            string setStatements = string.Join(", ", properties.Select(p => "[" + p.Name + "]" + "= @" + p.Name));

            string query = $"UPDATE {tableName} SET {setStatements} WHERE Id = @Id";

            connection.Execute(query, entity);
        }
    }
}
