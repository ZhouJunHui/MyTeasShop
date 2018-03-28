<%@ WebHandler Language="C#" Class="Teas_GetListByCateid" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Teas_GetListByCateid : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string cateId = context.Request.Params["cateId"];
        List<Teas> lst = new TeasManager().Teas_GetListByCateid(cateId);
        DataContractJsonSerializer dt = new DataContractJsonSerializer(typeof(List<Teas>));
        dt.WriteObject(context.Response.OutputStream, lst);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}