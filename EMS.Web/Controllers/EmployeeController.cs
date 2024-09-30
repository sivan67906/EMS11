using Application.Services.Implementation;
using Domain.Entities;
using Domain.Viewmodel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Web.Controllers;

[Authorize]
public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;
    public ViewResult Index()
    {
        List<EmployeeViewmodel> employeeViewmodel = _employeeService.GetAllEmployees();

        return View(employeeViewmodel);
    }

    [HttpGet]
    public ViewResult Edit(int id)
    {
        EmployeeViewmodel employeeViewmodel = _employeeService.GetEmployeeById(id);

        return View(employeeViewmodel);
    }

    [HttpPost]
    public IActionResult Edit(EmployeeViewmodel model)
    {
        //if (ModelState.IsValid)
        //{
        Employee employee = _employeeService.GetEmployee(model.Id);

        employee.FirstName = model.FirstName;
        employee.LastName = model.LastName;
        employee.Gender = model.Gndr;
        //employee.DateofBirth = model.DateofBirth;
        employee.EmpContactDetailId = 3;
        employee.EmpTypeId = 3;
        employee.EmpDepartmentId = 3;
        employee.EmpAccountId = 3;
        employee.EmpAuthenticationId = 3;
        employee.EmpRoleId = 3;
        employee.Created_Date = DateTime.Now;
        employee.Modified_Date = DateTime.Now;
        employee.CreatedBy = 1;
        employee.ModifiedBy = 1;

        ////}
        _employeeService.UpdateEmployee(employee);
        return RedirectToAction("Index", "Employee");
    }

    [HttpGet]
    public ViewResult Delete(int id)
    {
        EmployeeViewmodel employeeViewmodel = _employeeService.GetEmployeeById(id);
        return View(employeeViewmodel);
    }

    [HttpPost]
    public IActionResult Delete(EmployeeViewmodel model)
    {
        Employee employee = _employeeService.GetEmployee(model.Id);
        _employeeService.DeleteEmployee(employee);
        return RedirectToAction("Index", "Employee");
    }

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

}
