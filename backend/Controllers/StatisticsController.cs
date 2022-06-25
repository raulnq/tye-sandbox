using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class StatisticsController : ControllerBase
{
    private readonly string _connectionString;
    public StatisticsController(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("database");
    }

    [HttpGet]
    public async Task<IEnumerable<Statistics>> Get()
    {
        using (var con = new SqlConnection(_connectionString))
        {
            return await (con.QueryAsync<Statistics>("SELECT * FROM [Statistics]"));
        }
    }
}