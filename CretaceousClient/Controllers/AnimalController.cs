


public IActionResult Index()
{
  var allAnimals = Animal.GetAnimals();
  return View(allAnimals);
}