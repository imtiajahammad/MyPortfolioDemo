using DataAccess.DbGateways;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyPortfolioDemo.Controllers
{
    public class CommonController : ApiController
    {
        CommonGateway commonGateway;
        public CommonController()
        {
            commonGateway = new CommonGateway();
        }
        [HttpPut]
        public HttpResponseMessage UpdateSingleSmallTextModel(int id, [FromBody]SingleSmallTextModel singleSmallTextModel)
        {
            if (singleSmallTextModel == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "data with Id = " + id.ToString() + "not found to update");
            }
            try
            {
                commonGateway.UpdateSingleSmallTextModel(singleSmallTextModel);
                return Request.CreateResponse(HttpStatusCode.OK, singleSmallTextModel);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdateSingleLargeTextModel(int id, [FromBody]SingleLargeTextModel singleLargeTextModel)
        {
            if (singleLargeTextModel == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "data with Id = " + id.ToString() + "not found to update");
            }
            try
            {
                commonGateway.UpdateSingleLargeTextModel(singleLargeTextModel);
                return Request.CreateResponse(HttpStatusCode.OK, singleLargeTextModel);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdateSingleIntegerModel(int id, [FromBody]SingleIntegerModel singleIntegerModel)
        {
            if (singleIntegerModel == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "data with Id = " + id.ToString() + "not found to update");
            }
            try
            {
                commonGateway.UpdateSingleIntegerModel(singleIntegerModel);
                return Request.CreateResponse(HttpStatusCode.OK, singleIntegerModel);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdateSingleDateModel(int id, [FromBody]SingleDateModel singleDateModel)
        {
            if (singleDateModel == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "data with Id = " + id.ToString() + "not found to update");
            }
            try
            {
                commonGateway.UpdateSingleDateModel(singleDateModel);
                return Request.CreateResponse(HttpStatusCode.OK, singleDateModel);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdateLargeTextListDataModel(int id, [FromBody]LargeTextListDataModel largeTextListDataModel)
        {
            if (largeTextListDataModel == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "data with Id = " + id.ToString() + "not found to update");
            }
            try
            {
                commonGateway.UpdateLargeTextListDataModel(largeTextListDataModel);
                return Request.CreateResponse(HttpStatusCode.OK, largeTextListDataModel);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdateSmallTextListDataModel(int id, [FromBody]SmallTextListDataModel smallTextListDataModel)
        {
            if (smallTextListDataModel == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "data with Id = " + id.ToString() + "not found to update");
            }
            try
            {
                commonGateway.UpdateSmallTextListDataModel(smallTextListDataModel);
                return Request.CreateResponse(HttpStatusCode.OK, smallTextListDataModel);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPut]
        public HttpResponseMessage UpdateOnlineLinkDataModel(int id, [FromBody]OnlineLinkDataModel  onlineLinkDataModel)
        {
            if (onlineLinkDataModel == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "data with Id = " + id.ToString() + "not found to update");
            }
            try
            {
                commonGateway.UpdateOnlineLinkDataModel(onlineLinkDataModel);
                return Request.CreateResponse(HttpStatusCode.OK, onlineLinkDataModel);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpDelete]
        public HttpResponseMessage DeleteSingleSmallTextModel(int id)
        {
            try
            {
                commonGateway.DeleteSingleSmallTextModel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteSingleLargeTextModel(int id )
        {
            try
            {
                commonGateway.DeleteSingleSmallTextModel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteSingleIntegerModel(int id)
        {
            try
            {
                commonGateway.DeleteSingleSmallTextModel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteSingleDateModel(int id)
        {
            try
            {
                commonGateway.DeleteSingleSmallTextModel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteLargeTextListDataModel(int id)
        {
            try
            {
                commonGateway.DeleteSingleSmallTextModel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteSmallTextListDataModel(int id)
        {
            try
            {
                commonGateway.DeleteSingleSmallTextModel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpDelete]
        public HttpResponseMessage DeleteOnlineLinkDataModel(int id)
        {
            try
            {
                commonGateway.DeleteSingleSmallTextModel(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
