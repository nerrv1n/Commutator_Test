using System.Collections.Generic;
using System.Linq;
using Commutator.Models;
public class InMemorySwitchRepository
{
    public  List<Switch> _switches = [
        new Switch { Id = 1, Model = "Cisco Catalyst 2960", IpAddress = "192.168.1.1", MacAddress = "00:A0:C9:14:C8:29", Vlan = 10, SerialNumber = "SN123456", InventoryNumber = "INV001", PurchaseDate = DateTime.Parse("2020-01-15"), InstallationDate = DateTime.Parse("2020-02-01"), Floor = "1", Comment = "Основной коммутатор" },
        new Switch { Id = 2, Model = "HP ProCurve 2530", IpAddress = "192.168.1.2", MacAddress = "00:B1:D3:56:E8:45", Vlan = 20, SerialNumber = "SN654321", InventoryNumber = "INV002", PurchaseDate = DateTime.Parse("2019-05-10"), InstallationDate = DateTime.Parse("2019-06-15"), Floor = "2", Comment = "Резервный коммутатор" },
        new Switch { Id = 3, Model = "Dell PowerConnect 5548", IpAddress = "192.168.1.3", MacAddress = "00:C2:E4:78:F9:67", Vlan = 30, SerialNumber = "SN789012", InventoryNumber = "INV003", PurchaseDate = DateTime.Parse("2021-03-20"), InstallationDate = DateTime.Parse("2021-04-05"), Floor = "3", Comment = "Краевой коммутатор" },
        new Switch { Id = 4, Model = "Juniper EX3300", IpAddress = "192.168.1.4", MacAddress = "00:D3:F5:89:0A:78", Vlan = 40, SerialNumber = "SN456789", InventoryNumber = "INV004", PurchaseDate = DateTime.Parse("2022-07-12"), InstallationDate = DateTime.Parse("2022-08-01"), Floor = "4", Comment = "Коммутатор ядра сети" },
        new Switch { Id = 5, Model = "Netgear GS724T", IpAddress = "192.168.1.5", MacAddress = "00:E4:G6:9A:1B:89", Vlan = 50, SerialNumber = "SN987654", InventoryNumber = "INV005", PurchaseDate = DateTime.Parse("2018-11-05"), InstallationDate = DateTime.Parse("2018-12-10"), Floor = "5", Comment = "Распределительный коммутатор" },
        new Switch { Id = 6, Model = "TP-Link TL-SG1024", IpAddress = "192.168.1.6", MacAddress = "00:F5:H7:AB:2C:90", Vlan = 60, SerialNumber = "SN321987", InventoryNumber = "INV006", PurchaseDate = DateTime.Parse("2023-02-14"), InstallationDate = DateTime.Parse("2023-03-01"), Floor = "6", Comment = "Коммутатор доступа" },
        new Switch { Id = 7, Model = "Extreme Networks X440", IpAddress = "192.168.1.7", MacAddress = "00:G6:I8:BC:3D:A1", Vlan = 70, SerialNumber = "SN654987", InventoryNumber = "INV007", PurchaseDate = DateTime.Parse("2020-09-25"), InstallationDate = DateTime.Parse("2020-10-10"), Floor = "7", Comment = "Коммутатор центра обработки данных" },
        new Switch { Id = 8, Model = "Aruba 2930F", IpAddress = "192.168.1.8", MacAddress = "00:H7:J9:CD:4E:B2", Vlan = 80, SerialNumber = "SN852741", InventoryNumber = "INV008", PurchaseDate = DateTime.Parse("2021-06-30"), InstallationDate = DateTime.Parse("2021-07-15"), Floor = "8", Comment = "Беспроводной коммутатор" },
        new Switch { Id = 9, Model = "Brocade ICX 7250", IpAddress = "192.168.1.9", MacAddress = "00:I8:K0:DE:5F:C3", Vlan = 90, SerialNumber = "SN963258", InventoryNumber = "INV009", PurchaseDate = DateTime.Parse("2017-12-20"), InstallationDate = DateTime.Parse("2018-01-05"), Floor = "9", Comment = "Коммутатор серверной стойки" },
        new Switch { Id = 10, Model = "MikroTik CRS326", IpAddress = "192.168.1.10", MacAddress = "00:J9:L1:EF:6G:D4", Vlan = 100, SerialNumber = "SN147852", InventoryNumber = "INV010", PurchaseDate = DateTime.Parse("2024-01-01"), InstallationDate = DateTime.Parse("2024-01-15"), Floor = "10", Comment = "Новый установленный коммутатор" },
        new Switch { Id = 11, Model = "Extreme Networks X440", IpAddress = "192.168.1.7", MacAddress = "00:G6:I8:BC:3D:A1", Vlan = 70, SerialNumber = "SN654987", InventoryNumber = "INV007", PurchaseDate = DateTime.Parse("2020-09-25"), InstallationDate = DateTime.Parse("2020-10-10"), Floor = "7", Comment = "Коммутатор центра обработки данных" },
        new Switch { Id = 12, Model = "Aruba 2930F", IpAddress = "192.168.1.8", MacAddress = "00:H7:J9:CD:4E:B2", Vlan = 80, SerialNumber = "SN852741", InventoryNumber = "INV008", PurchaseDate = DateTime.Parse("2021-06-30"), InstallationDate = DateTime.Parse("2021-07-15"), Floor = "8", Comment = "Беспроводной коммутатор" },
        new Switch { Id = 13, Model = "Brocade ICX 7250", IpAddress = "192.168.1.9", MacAddress = "00:I8:K0:DE:5F:C3", Vlan = 90, SerialNumber = "SN963258", InventoryNumber = "INV009", PurchaseDate = DateTime.Parse("2017-12-20"), InstallationDate = DateTime.Parse("2018-01-05"), Floor = "9", Comment = "Коммутатор серверной стойки" },
        new Switch { Id = 14, Model = "MikroTik CRS326", IpAddress = "192.168.1.10", MacAddress = "00:J9:L1:EF:6G:D4", Vlan = 100, SerialNumber = "SN147852", InventoryNumber = "INV010", PurchaseDate = DateTime.Parse("2024-01-01"), InstallationDate = DateTime.Parse("2024-01-15"), Floor = "10", Comment = "Новый установленный коммутатор" },
        new Switch { Id = 15, Model = "Netgear GS724T", IpAddress = "192.168.1.5", MacAddress = "00:E4:G6:9A:1B:89", Vlan = 50, SerialNumber = "SN987654", InventoryNumber = "INV005", PurchaseDate = DateTime.Parse("2018-11-05"), InstallationDate = DateTime.Parse("2018-12-10"), Floor = "5", Comment = "Распределительный коммутатор" },
        new Switch { Id = 16, Model = "TP-Link TL-SG1024", IpAddress = "192.168.1.6", MacAddress = "00:F5:H7:AB:2C:90", Vlan = 60, SerialNumber = "SN321987", InventoryNumber = "INV006", PurchaseDate = DateTime.Parse("2023-02-14"), InstallationDate = DateTime.Parse("2023-03-01"), Floor = "6", Comment = "Коммутатор доступа" },
        new Switch { Id = 17, Model = "Extreme Networks X440", IpAddress = "192.168.1.7", MacAddress = "00:G6:I8:BC:3D:A1", Vlan = 70, SerialNumber = "SN654987", InventoryNumber = "INV007", PurchaseDate = DateTime.Parse("2020-09-25"), InstallationDate = DateTime.Parse("2020-10-10"), Floor = "7", Comment = "Коммутатор центра обработки данных" },
        new Switch { Id = 18, Model = "Aruba 2930F", IpAddress = "192.168.1.8", MacAddress = "00:H7:J9:CD:4E:B2", Vlan = 80, SerialNumber = "SN852741", InventoryNumber = "INV008", PurchaseDate = DateTime.Parse("2021-06-30"), InstallationDate = DateTime.Parse("2021-07-15"), Floor = "8", Comment = "Беспроводной коммутатор" },
        new Switch { Id = 19, Model = "Brocade ICX 7250", IpAddress = "192.168.1.9", MacAddress = "00:I8:K0:DE:5F:C3", Vlan = 90, SerialNumber = "SN963258", InventoryNumber = "INV009", PurchaseDate = DateTime.Parse("2017-12-20"), InstallationDate = DateTime.Parse("2018-01-05"), Floor = "9", Comment = "Коммутатор серверной стойки" },
        new Switch { Id = 20, Model = "MikroTik CRS326", IpAddress = "192.168.1.10", MacAddress = "00:J9:L1:EF:6G:D4", Vlan = 100, SerialNumber = "SN147852", InventoryNumber = "INV010", PurchaseDate = DateTime.Parse("2024-01-01"), InstallationDate = DateTime.Parse("2024-01-15"), Floor = "10", Comment = "Новый установленный коммутатор" },
        new Switch { Id = 21, Model = "Extreme Networks X440", IpAddress = "192.168.1.7", MacAddress = "00:G6:I8:BC:3D:A1", Vlan = 70, SerialNumber = "SN654987", InventoryNumber = "INV007", PurchaseDate = DateTime.Parse("2020-09-25"), InstallationDate = DateTime.Parse("2020-10-10"), Floor = "7", Comment = "Коммутатор центра обработки данных" },
        new Switch { Id = 22, Model = "Aruba 2930F", IpAddress = "192.168.1.8", MacAddress = "00:H7:J9:CD:4E:B2", Vlan = 80, SerialNumber = "SN852741", InventoryNumber = "INV008", PurchaseDate = DateTime.Parse("2021-06-30"), InstallationDate = DateTime.Parse("2021-07-15"), Floor = "8", Comment = "Беспроводной коммутатор" },
        new Switch { Id = 23, Model = "Brocade ICX 7250", IpAddress = "192.168.1.9", MacAddress = "00:I8:K0:DE:5F:C3", Vlan = 90, SerialNumber = "SN963258", InventoryNumber = "INV009", PurchaseDate = DateTime.Parse("2017-12-20"), InstallationDate = DateTime.Parse("2018-01-05"), Floor = "9", Comment = "Коммутатор серверной стойки" },
    ];

    public IEnumerable<Switch> GetPagedSwitches(int page, int pageSize)
    {
        return _switches.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }

    public int GetTotalCount()
    {
        return _switches.Count;
    }

    public List<Switch> GetAll() => _switches;

    public Switch GetById(int id) => _switches.FirstOrDefault(s => s.Id == id);

    public void Add(Switch switchEntity)
    {
        switchEntity.Id = _switches.Any() ? _switches.Max(s => s.Id) + 1 : 1;
        _switches.Add(switchEntity);
    }

    public void Update(Switch switchEntity)
{
    var existingSwitch = _switches.FirstOrDefault(s => s.Id == switchEntity.Id);
    if (existingSwitch != null)
    {
        existingSwitch.Model = switchEntity.Model;
        existingSwitch.IpAddress = switchEntity.IpAddress;
        existingSwitch.SerialNumber = switchEntity.SerialNumber;
        existingSwitch.MacAddress = switchEntity.MacAddress;
        existingSwitch.Vlan = switchEntity.Vlan;
        existingSwitch.InventoryNumber = switchEntity.InventoryNumber;
        existingSwitch.PurchaseDate = switchEntity.PurchaseDate;
        existingSwitch.InstallationDate = switchEntity.InstallationDate;
        existingSwitch.Floor = switchEntity.Floor;
        existingSwitch.Comment = switchEntity.Comment;
    }
}


    public void Delete(int id)
    {
        var switchEntity = GetById(id);
        if (switchEntity != null)
        {
            _switches.Remove(switchEntity);
        }
    }
}
