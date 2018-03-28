<%@ WebHandler Language="C#" Class="UpdatePwd_User" %>

using System;
using System.Web;
using Model;
using BLL;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;
public class UpdatePwd_User : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string Uid = context.Request.Params["Uid"];
        string PwdNew=context.Request.Params["PwdNew"];
        bool boo = new UserManager().UpdatePwd(Uid,PwdNew);
        DataContractJsonSerializer ds = new DataContractJsonSerializer(typeof(bool));
        ds.WriteObject(context.Response.OutputStream, boo);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}