using System;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using CRUDAPI.Models;

namespace CRUDAPI.Controllers
{
    [RoutePrefix("Api/Patient")]
    public class PatientController : ApiController
    {



        imetx_dev_dbEntities objEntity = new imetx_dev_dbEntities();

        [HttpGet]
        [Route("AllPatientDetails")]
        public IQueryable<tblTestPatient> GetEmaployee()
        {
            try
            {
                return objEntity.tblTestPatients;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("GetPatientDetailsById/{patPatientId}")]
        public IHttpActionResult GetEmaployeeById(string patPatientId)
        {
            tblTestPatient objEmp = new tblTestPatient();
            int ID = Convert.ToInt32(patPatientId);
            try
            {
                objEmp = objEntity.tblTestPatients.Find(ID);
                if (objEmp == null)
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                throw;
            }

            return Ok(objEmp);
        }

        [HttpPost]
        [Route("InsertPatientDetails")]
        public IHttpActionResult PostEmaployee(tblTestPatient data)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                objEntity.tblTestPatients.Add(data);
                objEntity.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }



            return Ok(data);
        }

        [HttpPut]
        [Route("UpdatePatientDetails")]
        public IHttpActionResult PutEmaployeeMaster(tblTestPatient employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                tblTestPatient objEmp = new tblTestPatient();
                objEmp = objEntity.tblTestPatients.Find(employee.patPatientId);
                if (objEmp != null)
                {
                    objEmp.patPatientName = employee.patPatientName;
                    objEmp.patAddress = employee.patAddress;
                    objEmp.patEmailId = employee.patEmailId;
                    objEmp.patDateOfBirth = employee.patDateOfBirth;
                    objEmp.patGender = employee.patGender;
                    objEmp.patPinCode = employee.patPinCode;

                }
                int i = this.objEntity.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            return Ok(employee);
        }
        [HttpDelete]
        [Route("DeletePatientDetails")]
        public IHttpActionResult DeleteEmaployeeDelete(int id)
        {
            //int empId = Convert.ToInt32(id);
            tblTestPatient emaployee = objEntity.tblTestPatients.Find(id);
            if (emaployee == null)
            {
                return NotFound();
            }

            objEntity.tblTestPatients.Remove(emaployee);
            objEntity.SaveChanges();

            return Ok(emaployee);
        }

    }
}
