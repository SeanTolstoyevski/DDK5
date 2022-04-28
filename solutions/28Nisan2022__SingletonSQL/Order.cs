

namespace singleton;

public class Order
{

    public int OrderId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }



    public decimal Freight { get; set; }
    public string ShipCity { get; set; }
    public string ShipCounty { get; set; }



}