<%@ WebHandler Language="C#" Class="Update_personalInfo" %>

using System;
using System.Web;
using BLL;
using Model;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class Update_personalInfo : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        UsersPersonInfo Info = new UsersPersonInfo();
        Info.Uid =Convert.ToInt32(context.Request.Params["Uid"]);
        Info.Uname = context.Request.Params["Uname"];
        Info.Sex = context.Request.Params["Sex"];
        Info.Phone = context.Request.Params["Phone"];
        if (context.Request.Params["Birthday"] == "")
            Info.Birthday = null;
        else
            Info.Birthday = Convert.ToDateTime(context.Request.Params["Birthday"]);
        bool boo = new PersonalInfoManager().Update(Info);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(bool));
        ds.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}