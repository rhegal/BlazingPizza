namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        // Call your data access technology here
        await Task.Delay(1000);
        return new Pizza[] { new Pizza { PizzaId = 1,}} ;
    }
}