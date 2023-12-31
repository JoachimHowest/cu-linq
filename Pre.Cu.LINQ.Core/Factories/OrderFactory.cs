using Pre.Cu.LINQ.Core.Domain;

namespace Pre.Cu.LINQ.Core.Factories;

public class OrderFactory : IOrderFactory
{
    public IEnumerable<Order> CreateDefaults(IEnumerable<Employee> employees, IEnumerable<Customer> customers)
    {
        return new List<Order>()
        {
            new Order(10248, customers.SingleOrDefault(c => c.Id == "VINET"), employees.SingleOrDefault(c => c.Id == 5),
                DateTime.Parse("Jul  4 1996 12:00AM"), DateTime.Parse("Aug  1 1996 12:00AM"),
                DateTime.Parse("Jul 16 1996 12:00AM"),
                new Address("59 rue de l'Abbaye", "Reims", "", "51100", "France"), 3, 32.38M),
            new Order(10249, customers.SingleOrDefault(c => c.Id == "TOMSP"), employees.SingleOrDefault(c => c.Id == 6),
                DateTime.Parse("Jul  5 1996 12:00AM"), DateTime.Parse("Aug 16 1996 12:00AM"),
                DateTime.Parse("Jul 10 1996 12:00AM"), new Address("Luisenstr. 48", "Münster", "", "44087", "Germany"),
                1, 11.61M),
            new Order(10250, customers.SingleOrDefault(c => c.Id == "HANAR"), employees.SingleOrDefault(c => c.Id == 4),
                DateTime.Parse("Jul  8 1996 12:00AM"), DateTime.Parse("Aug  5 1996 12:00AM"),
                DateTime.Parse("Jul 12 1996 12:00AM"),
                new Address("Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"), 2, 65.83M),
            new Order(10251, customers.SingleOrDefault(c => c.Id == "VICTE"), employees.SingleOrDefault(c => c.Id == 3),
                DateTime.Parse("Jul  8 1996 12:00AM"), DateTime.Parse("Aug  5 1996 12:00AM"),
                DateTime.Parse("Jul 15 1996 12:00AM"), new Address("2, rue du Commerce", "Lyon", "", "69004", "France"),
                1, 41.34M),
            new Order(10252, customers.SingleOrDefault(c => c.Id == "SUPRD"), employees.SingleOrDefault(c => c.Id == 4),
                DateTime.Parse("Jul  9 1996 12:00AM"), DateTime.Parse("Aug  6 1996 12:00AM"),
                DateTime.Parse("Jul 11 1996 12:00AM"),
                new Address("Boulevard Tirou, 255", "Charleroi", "", "B-6000", "Belgium"), 2, 51.30M),
            new Order(10253, customers.SingleOrDefault(c => c.Id == "HANAR"), employees.SingleOrDefault(c => c.Id == 3),
                DateTime.Parse("Jul 10 1996 12:00AM"), DateTime.Parse("Jul 24 1996 12:00AM"),
                DateTime.Parse("Jul 16 1996 12:00AM"),
                new Address("Rua do Paço, 67", "Rio de Janeiro", "RJ", "05454-876", "Brazil"), 2, 58.17M),
            new Order(10254, customers.SingleOrDefault(c => c.Id == "CHOPS"), employees.SingleOrDefault(c => c.Id == 5),
                DateTime.Parse("Jul 11 1996 12:00AM"), DateTime.Parse("Aug  8 1996 12:00AM"),
                DateTime.Parse("Jul 23 1996 12:00AM"), new Address("Hauptstr. 31", "Bern", "", "3012", "Switzerland"),
                2, 22.98M),
            new Order(10255, customers.SingleOrDefault(c => c.Id == "RICSU"), employees.SingleOrDefault(c => c.Id == 9),
                DateTime.Parse("Jul 12 1996 12:00AM"), DateTime.Parse("Aug  9 1996 12:00AM"),
                DateTime.Parse("Jul 15 1996 12:00AM"), new Address("Starenweg 5", "Genève", "", "1204", "Switzerland"),
                3, 148.33M),
            new Order(10256, customers.SingleOrDefault(c => c.Id == "WELLI"), employees.SingleOrDefault(c => c.Id == 3),
                DateTime.Parse("Jul 15 1996 12:00AM"), DateTime.Parse("Aug 12 1996 12:00AM"),
                DateTime.Parse("Jul 17 1996 12:00AM"),
                new Address("Rua do Mercado, 12", "Resende", "SP", "08737-363", "Brazil"), 2, 13.97M),
            new Order(10257, customers.SingleOrDefault(c => c.Id == "HILAA"), employees.SingleOrDefault(c => c.Id == 4),
                DateTime.Parse("Jul 16 1996 12:00AM"), DateTime.Parse("Aug 13 1996 12:00AM"),
                DateTime.Parse("Jul 22 1996 12:00AM"),
                new Address("Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "Táchira", "5022",
                    "Venezuela"), 3, 81.91M),
            new Order(10258, customers.SingleOrDefault(c => c.Id == "ERNSH"), employees.SingleOrDefault(c => c.Id == 1),
                DateTime.Parse("Jul 17 1996 12:00AM"), DateTime.Parse("Aug 14 1996 12:00AM"),
                DateTime.Parse("Jul 23 1996 12:00AM"), new Address("Kirchgasse 6", "Graz", "", "8010", "Austria"), 1,
                140.51M),
            new Order(10259, customers.SingleOrDefault(c => c.Id == "CENTC"), employees.SingleOrDefault(c => c.Id == 4),
                DateTime.Parse("Jul 18 1996 12:00AM"), DateTime.Parse("Aug 15 1996 12:00AM"),
                DateTime.Parse("Jul 25 1996 12:00AM"),
                new Address("Sierras de Granada 9993", "México D.F.", "", "05022", "Mexico"), 3, 3.25M),
            new Order(10260, customers.SingleOrDefault(c => c.Id == "OTTIK"), employees.SingleOrDefault(c => c.Id == 4),
                DateTime.Parse("Jul 19 1996 12:00AM"), DateTime.Parse("Aug 16 1996 12:00AM"),
                DateTime.Parse("Jul 29 1996 12:00AM"),
                new Address("Mehrheimerstr. 369", "Köln", "", "50739", "Germany"), 1, 55.09M),
            new Order(10261, customers.SingleOrDefault(c => c.Id == "QUEDE"), employees.SingleOrDefault(c => c.Id == 4),
                DateTime.Parse("Jul 19 1996 12:00AM"), DateTime.Parse("Aug 16 1996 12:00AM"),
                DateTime.Parse("Jul 30 1996 12:00AM"),
                new Address("Rua da Panificadora, 12", "Rio de Janeiro", "RJ", "02389-673", "Brazil"), 2, 3.05M),
            new Order(10262, customers.SingleOrDefault(c => c.Id == "RATTC"), employees.SingleOrDefault(c => c.Id == 8),
                DateTime.Parse("Jul 22 1996 12:00AM"), DateTime.Parse("Aug 19 1996 12:00AM"),
                DateTime.Parse("Jul 25 1996 12:00AM"),
                new Address("2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"), 3, 48.29M),
            new Order(10263, customers.SingleOrDefault(c => c.Id == "ERNSH"), employees.SingleOrDefault(c => c.Id == 9),
                DateTime.Parse("Jul 23 1996 12:00AM"), DateTime.Parse("Aug 20 1996 12:00AM"),
                DateTime.Parse("Jul 31 1996 12:00AM"), new Address("Kirchgasse 6", "Graz", "", "8010", "Austria"), 3,
                146.06M),
            new Order(10264, customers.SingleOrDefault(c => c.Id == "FOLKO"), employees.SingleOrDefault(c => c.Id == 6),
                DateTime.Parse("Jul 24 1996 12:00AM"), DateTime.Parse("Aug 21 1996 12:00AM"),
                DateTime.Parse("Aug 23 1996 12:00AM"), new Address("Åkergatan 24", "Bräcke", "", "S-844 67", "Sweden"),
                3, 3.67M),
            new Order(10265, customers.SingleOrDefault(c => c.Id == "BLONP"), employees.SingleOrDefault(c => c.Id == 2),
                DateTime.Parse("Jul 25 1996 12:00AM"), DateTime.Parse("Aug 22 1996 12:00AM"),
                DateTime.Parse("Aug 12 1996 12:00AM"),
                new Address("24, place Kléber", "Strasbourg", "", "67000", "France"), 1, 55.28M),
            new Order(10266, customers.SingleOrDefault(c => c.Id == "WARTH"), employees.SingleOrDefault(c => c.Id == 3),
                DateTime.Parse("Jul 26 1996 12:00AM"), DateTime.Parse("Sep  6 1996 12:00AM"),
                DateTime.Parse("Jul 31 1996 12:00AM"), new Address("Torikatu 38", "Oulu", "", "90110", "Finland"), 3,
                25.73M),
            new Order(10267, customers.SingleOrDefault(c => c.Id == "FRANK"), employees.SingleOrDefault(c => c.Id == 4),
                DateTime.Parse("Jul 29 1996 12:00AM"), DateTime.Parse("Aug 26 1996 12:00AM"),
                DateTime.Parse("Aug  6 1996 12:00AM"),
                new Address("Berliner Platz 43", "München", "", "80805", "Germany"), 1, 208.58M),
            new Order(10268, customers.SingleOrDefault(c => c.Id == "GROSR"), employees.SingleOrDefault(c => c.Id == 8),
                DateTime.Parse("Jul 30 1996 12:00AM"), DateTime.Parse("Aug 27 1996 12:00AM"),
                DateTime.Parse("Aug  2 1996 12:00AM"),
                new Address("5ª Ave. Los Palos Grandes", "Caracas", "DF", "1081", "Venezuela"), 3, 66.29M),
            new Order(10269, customers.SingleOrDefault(c => c.Id == "WHITC"), employees.SingleOrDefault(c => c.Id == 5),
                DateTime.Parse("Jul 31 1996 12:00AM"), DateTime.Parse("Aug 14 1996 12:00AM"),
                DateTime.Parse("Aug  9 1996 12:00AM"),
                new Address("1029 - 12th Ave. S.", "Seattle", "WA", "98124", "USA"), 1, 4.56M),
            new Order(10270, customers.SingleOrDefault(c => c.Id == "WARTH"), employees.SingleOrDefault(c => c.Id == 1),
                DateTime.Parse("Aug  1 1996 12:00AM"), DateTime.Parse("Aug 29 1996 12:00AM"),
                DateTime.Parse("Aug  2 1996 12:00AM"), new Address("Torikatu 38", "Oulu", "", "90110", "Finland"), 1,
                136.54M),
            new Order(10271, customers.SingleOrDefault(c => c.Id == "SPLIR"), employees.SingleOrDefault(c => c.Id == 6),
                DateTime.Parse("Aug  1 1996 12:00AM"), DateTime.Parse("Aug 29 1996 12:00AM"),
                DateTime.Parse("Aug 30 1996 12:00AM"), new Address("P.O. Box 555", "Lander", "WY", "82520", "USA"), 2,
                4.54M),
            new Order(10272, customers.SingleOrDefault(c => c.Id == "RATTC"), employees.SingleOrDefault(c => c.Id == 6),
                DateTime.Parse("Aug  2 1996 12:00AM"), DateTime.Parse("Aug 30 1996 12:00AM"),
                DateTime.Parse("Aug  6 1996 12:00AM"),
                new Address("2817 Milton Dr.", "Albuquerque", "NM", "87110", "USA"), 2, 98.03M),
        };
    }

    public IEnumerable<OrderLine> CreateOrderLine(IEnumerable<Order> orders, IEnumerable<Product> products)
    {
        var orderLines = new List<OrderLine>()
        {
            new OrderLine(10248, products.SingleOrDefault(p => p.Id == 11), 14.00M, 12, 0M),
            new OrderLine(10248, products.SingleOrDefault(p => p.Id == 12), 9.80M, 10, 0M),
            new OrderLine(10248, products.SingleOrDefault(p => p.Id == 2), 34.80M, 5, 0M),
            new OrderLine(10249, products.SingleOrDefault(p => p.Id == 14), 18.60M, 9, 0M),
            new OrderLine(10249, products.SingleOrDefault(p => p.Id == 1), 42.40M, 40, 0M),
            new OrderLine(10250, products.SingleOrDefault(p => p.Id == 14), 7.70M, 10, 0M),
            new OrderLine(10250, products.SingleOrDefault(p => p.Id == 20), 42.40M, 35, 0.15M),
            new OrderLine(10250, products.SingleOrDefault(p => p.Id == 15), 16.80M, 15, 0.15M),
            new OrderLine(10251, products.SingleOrDefault(p => p.Id == 12), 16.80M, 6, 0.05M),
            new OrderLine(10251, products.SingleOrDefault(p => p.Id == 17), 15.60M, 15, 0.05M),
            new OrderLine(10251, products.SingleOrDefault(p => p.Id == 15), 16.80M, 20, 0M),
            new OrderLine(10252, products.SingleOrDefault(p => p.Id == 20), 64.80M, 40, 0.05M),
            new OrderLine(10252, products.SingleOrDefault(p => p.Id == 13), 2.00M, 25, 0.05M),
            new OrderLine(10252, products.SingleOrDefault(p => p.Id == 10), 27.20M, 40, 0M),
            new OrderLine(10253, products.SingleOrDefault(p => p.Id == 11), 10.00M, 20, 0M),
            new OrderLine(10253, products.SingleOrDefault(p => p.Id == 19), 14.40M, 42, 0M),
            new OrderLine(10253, products.SingleOrDefault(p => p.Id == 9), 16.00M, 40, 0M),
            new OrderLine(10254, products.SingleOrDefault(p => p.Id == 14), 3.60M, 15, 0.15M),
            new OrderLine(10254, products.SingleOrDefault(p => p.Id == 5), 19.20M, 21, 0.15M),
            new OrderLine(10254, products.SingleOrDefault(p => p.Id == 4), 8.00M, 21, 0M),
            new OrderLine(10255, products.SingleOrDefault(p => p.Id == 2), 15.20M, 20, 0M),
            new OrderLine(10255, products.SingleOrDefault(p => p.Id == 16), 13.90M, 35, 0M),
            new OrderLine(10255, products.SingleOrDefault(p => p.Id == 17), 15.20M, 25, 0M),
            new OrderLine(10255, products.SingleOrDefault(p => p.Id == 9), 44.00M, 30, 0M),
            new OrderLine(10256, products.SingleOrDefault(p => p.Id == 3), 26.20M, 15, 0M),
            new OrderLine(10256, products.SingleOrDefault(p => p.Id == 7), 10.40M, 12, 0M),
            new OrderLine(10257, products.SingleOrDefault(p => p.Id == 7), 35.10M, 25, 0M),
            new OrderLine(10257, products.SingleOrDefault(p => p.Id == 9), 14.40M, 6, 0M),
            new OrderLine(10257, products.SingleOrDefault(p => p.Id == 17), 10.40M, 15, 0M),
            new OrderLine(10258, products.SingleOrDefault(p => p.Id == 2), 15.20M, 50, 0.2M),
            new OrderLine(10258, products.SingleOrDefault(p => p.Id == 15), 17.00M, 65, 0.2M),
            new OrderLine(10258, products.SingleOrDefault(p => p.Id == 18), 25.60M, 6, 0.2M),
            new OrderLine(10259, products.SingleOrDefault(p => p.Id == 20), 8.00M, 10, 0M),
            new OrderLine(10259, products.SingleOrDefault(p => p.Id == 17), 20.80M, 1, 0M),
            new OrderLine(10260, products.SingleOrDefault(p => p.Id == 1), 7.70M, 16, 0.25M),
            new OrderLine(10260, products.SingleOrDefault(p => p.Id == 7), 15.60M, 50, 0M),
            new OrderLine(10260, products.SingleOrDefault(p => p.Id == 2), 39.40M, 15, 0.25M),
            new OrderLine(10260, products.SingleOrDefault(p => p.Id == 17), 12.00M, 21, 0.25M),
            new OrderLine(10261, products.SingleOrDefault(p => p.Id == 20), 8.00M, 20, 0M),
            new OrderLine(10261, products.SingleOrDefault(p => p.Id == 15), 14.40M, 20, 0M),
            new OrderLine(10262, products.SingleOrDefault(p => p.Id == 5), 17.00M, 12, 0.2M),
            new OrderLine(10262, products.SingleOrDefault(p => p.Id == 7), 24.00M, 15, 0M),
            new OrderLine(10262, products.SingleOrDefault(p => p.Id == 16), 30.40M, 2, 0M),
            new OrderLine(10263, products.SingleOrDefault(p => p.Id == 16), 13.90M, 60, 0.25M),
            new OrderLine(10263, products.SingleOrDefault(p => p.Id == 4), 3.60M, 28, 0M),
            new OrderLine(10263, products.SingleOrDefault(p => p.Id == 10), 20.70M, 60, 0.25M),
            new OrderLine(10263, products.SingleOrDefault(p => p.Id == 14), 8.00M, 36, 0.25M),
            new OrderLine(10264, products.SingleOrDefault(p => p.Id == 2), 15.20M, 35, 0M),
            new OrderLine(10264, products.SingleOrDefault(p => p.Id == 1), 7.70M, 25, 0.15M),
            new OrderLine(10265, products.SingleOrDefault(p => p.Id == 17), 31.20M, 30, 0M),
            new OrderLine(10265, products.SingleOrDefault(p => p.Id == 10), 12.00M, 20, 0M),
            new OrderLine(10266, products.SingleOrDefault(p => p.Id == 12), 30.40M, 12, 0.05M),
            new OrderLine(10267, products.SingleOrDefault(p => p.Id == 10), 14.70M, 50, 0M),
            new OrderLine(10267, products.SingleOrDefault(p => p.Id == 19), 44.00M, 70, 0.15M),
            new OrderLine(10267, products.SingleOrDefault(p => p.Id == 16), 14.40M, 15, 0.15M),
            new OrderLine(10268, products.SingleOrDefault(p => p.Id == 19), 99.00M, 10, 0M),
            new OrderLine(10268, products.SingleOrDefault(p => p.Id == 12), 27.80M, 4, 0M),
            new OrderLine(10269, products.SingleOrDefault(p => p.Id == 13), 2.00M, 60, 0.05M),
            new OrderLine(10269, products.SingleOrDefault(p => p.Id == 2), 27.80M, 20, 0.05M),
            new OrderLine(10270, products.SingleOrDefault(p => p.Id == 16), 15.20M, 30, 0M),
            new OrderLine(10270, products.SingleOrDefault(p => p.Id == 13), 36.80M, 25, 0M),
            new OrderLine(10271, products.SingleOrDefault(p => p.Id == 3), 2.00M, 24, 0M),
        };

        orders.ToList().ForEach(o => { o.OrderDetails.AddRange(orderLines.Where(ol => ol.OrderId == o.Id)); });

        return orderLines;
    }

    public IEnumerable<Order> CreateDefaults()
    {
        throw new NotImplementedException();
    }
}