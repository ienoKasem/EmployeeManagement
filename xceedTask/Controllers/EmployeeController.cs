using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using xceedTask.Models;
using xceedTask.Repository;
using xceedTask.ViewModel;

namespace xceedTask.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        IEmployeeRepository _employeeRepository;
        IEmployeeLOFRepository _employeeLOFRepository;
        IRepository<EmployeeLanguage> _employeeLanguageRepository;
        IRepository<Language> _languageRepository;
        IRepository<LineOFBusiness> _linOfBusinessRepository;
        IRepository<Account> _AccountRepository;


        public EmployeeController(IEmployeeRepository empRepository,
            IRepository<EmployeeLanguage> employeeLanguageRepository,
            IRepository<Language> languageRepository,
            IRepository<LineOFBusiness> linOfBusinessRepository,
            IRepository<Account> AccountRepository,
             IEmployeeLOFRepository employeeLOFRepository)
        {
            _employeeRepository = empRepository;
            _employeeLanguageRepository = employeeLanguageRepository;
            _languageRepository = languageRepository;
            _linOfBusinessRepository= linOfBusinessRepository;
            _AccountRepository = AccountRepository;
            _employeeLOFRepository = employeeLOFRepository;

        }
        public IActionResult Index()
        {

            TestViewModel tvm= new TestViewModel();
            tvm.Employees = _employeeRepository.GetAll();
            tvm.Accounts = _AccountRepository.GetAll();
            tvm.LineOFBusinesses = _linOfBusinessRepository.GetAll();
            tvm.EmployeeLanguages = _employeeLanguageRepository.GetAll();
            tvm.Languages= _languageRepository.GetAll();            
            return View(tvm);
        }
        [Authorize(Roles ="Admin,Mang")]
        public IActionResult Create() {
            ViewBag.Accounts=_AccountRepository.GetAll();
            ViewBag.Languages=_languageRepository.GetAll();
            ViewData["LineOFBusinesses"] =_linOfBusinessRepository.GetAll();
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Mang")]
        public IActionResult Create(Employee emp,string[] LineOFBusinesses, string[] selectedLang, string[] oral, string[] writting, string[] speaking, string[] listening)
        {
           
            
            _employeeRepository.Insert(emp);
            _employeeRepository.Save();
            

                foreach (string item in LineOFBusinesses)
                {
                    EmployeeLineOfBusiness lof = new EmployeeLineOfBusiness();
                    lof.Eid = emp.Id;
                    lof.LofId = int.Parse(item);
                _employeeLOFRepository.Insert(lof);
                _employeeLOFRepository.Save();
                }
                foreach (string item in selectedLang)
            {
                EmployeeLanguage Elang = new EmployeeLanguage();
                Elang.EId= emp.Id;
                Elang.LId=int.Parse(item);
                for (int i = 0; i < oral.Length; i++)
                {
                    if (i  == int.Parse(item)-1)
                    {
                        Elang.Oral= oral[i];
                        Elang.Listening= listening[i];
                        Elang.Writing = writting[i];
                        Elang.Speaking= speaking[i];
                    }
                
                }
                _employeeLanguageRepository.Insert(Elang);
                _employeeLanguageRepository.Save();


            }
         




            


            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin,Mang")]
        public IActionResult Remove(int id)
        {
            _employeeRepository.Delete(id);
            _employeeLOFRepository.Delete(id);
            _employeeRepository.Save();
            return RedirectToAction("index");

        }
        public IActionResult GetLOFByAccId(int Aid)
        {
            List<LineOFBusiness> lof=_employeeRepository.GetByAccID(Aid);
            return Json(lof);
        }
        [Authorize(Roles = "Admin,Mang")]
        public IActionResult Edit(int id)
        {
            Employee empModel= _employeeRepository.GetById(id);
            return View(empModel);
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Mang")]
        public IActionResult Edit(int id,Employee emp)
        {
            Employee empModel = _employeeRepository.GetById(id);
            emp.Aid= empModel.Aid;
            _employeeRepository.Update(id,emp);
            _employeeRepository.Save();
            return RedirectToAction("Index");       
        }
    }
}
