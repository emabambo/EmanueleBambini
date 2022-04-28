namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        return Task.FromResult(new List<Pizza>().ToArray());
        
    }
}
