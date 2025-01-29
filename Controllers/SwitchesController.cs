using Microsoft.AspNetCore.Mvc;
using Commutator.Models;

public class SwitchesController : Controller
{
    private readonly InMemorySwitchRepository _repository;
    private const int PageSize = 5;

    public SwitchesController(InMemorySwitchRepository repository)
    {
        _repository = repository;
    }

    public IActionResult Index(String search, String modelFilter, String ipFilter, String macFilter, String vlanFilter, String inventoryFilter, String floorFilter, int page = 1)
    {

        var switches = _repository.GetPagedSwitches(page, PageSize);
        var query = _repository._switches.AsQueryable();
        int totalCount = _repository.GetTotalCount();

        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(s => s.Model.Contains(search));
        }

        if (!string.IsNullOrEmpty(modelFilter))
        {
            query = query.Where(s => s.Model.Contains(modelFilter));
        }

        if (!string.IsNullOrEmpty(ipFilter))
        {
            query = query.Where(s => s.IpAddress.Contains(ipFilter));
        }

        if (!string.IsNullOrEmpty(macFilter))
        {
            query = query.Where(s => s.MacAddress.Contains(macFilter));
        }

        if (!string.IsNullOrEmpty(vlanFilter))
        {
            query = query.Where(s => Convert.ToString(s.Vlan).Contains(vlanFilter));
        }

        if (!string.IsNullOrEmpty(inventoryFilter))
        {
            query = query.Where(s => s.InventoryNumber.Contains(inventoryFilter));
        }

        if (!string.IsNullOrEmpty(floorFilter))
        {
            query = query.Where(s => s.Floor.Contains(floorFilter));
        }
        int pageSize = 5;
        switches = query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        var viewModel = new SwitchesViewModel
        {
            Switches = switches.ToList(),
            CurrentPage = page,
            TotalPages = (int)Math.Ceiling(totalCount / (double)PageSize),
            SearchQuery = search,
            ModelFilter = modelFilter,
            IpFilter =ipFilter,
            MacFilter=macFilter,
            VlanFilter = vlanFilter,
            InventoryFilter = inventoryFilter,
            FloorFilter = floorFilter,
        };

        return View(viewModel);
    }

    public IActionResult Details(int id)
    {
        var switchEntity = _repository.GetById(id);
        if (switchEntity == null) return NotFound();
        return View(switchEntity);
    }

    public IActionResult Create()
    {
        return View(new Switch());
    }

    [HttpPost]
    public IActionResult Create(Switch newSwitch)
    {
        if (ModelState.IsValid)
        {
            _repository.Add(newSwitch);
            return RedirectToAction("Index");
        }

        return View(newSwitch);
    }
    public IActionResult Edit(int id)
    {
        var switchEntity = _repository.GetById(id);
        if (switchEntity == null) return NotFound();
        return View(switchEntity);
    }

    [HttpPost]
    public IActionResult Edit(Switch switchEntity)
    {
        if (!ModelState.IsValid) return View(switchEntity);

        _repository.Update(switchEntity);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var switchEntity = _repository.GetById(id);
        if (switchEntity == null) return NotFound();
        return View(switchEntity);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _repository.Delete(id);
        return RedirectToAction(nameof(Index));
    }
}
