using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApplication1.Models
{
    public class Api
    {
        public string url = "http://www.tzsbks.sh.cn/services/JsScInterface";
        public string username = "TSZK31001";
        public string pass = "F123456";
        public XmlNodeList beam;
        // public Student st;
        public string queryNjScpcInfo(string lq = "2356")
        {
            StringBuilder soap = new StringBuilder();
            soap.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            soap.Append("<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:web=\"http://schemas.xmlsoap.org/soap/envelope/\">");
            soap.Append("<soapenv:Header/>");
            soap.Append("<soapenv:Body>");
            soap.Append("<web:queryNjScpcInfo>");
            soap.Append("<web:in0>" + username + "</web:in0>");
            soap.Append("<web:in1>" + pass + "</web:in1>");
            // soap.Append("<web:in2>2023-09-04</web:in2>");
            soap.Append("<web:in2>" + lq + "</web:in2>");
            soap.Append("</web:queryNjScpcInfo>");
            soap.Append("</soapenv:Body>");
            soap.Append("</soapenv:Envelope>");

            //发起请求
            Uri uri = new Uri(url);
            string a = "";
            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.ContentType = "text/xml; charset=UTF-8";
                webRequest.Method = "POST";
                // webRequest.Headers.Add("SOAPAction", "http://bean.webservice.jerry.com");
                byte[] paramBytes;
                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    paramBytes = Encoding.UTF8.GetBytes(soap.ToString());
                    requestStream.Write(paramBytes, 0, paramBytes.Length);
                }
                //    MessageBox.Show(soap.ToString());
                //  MessageBox.Show(BitConverter.ToString(paramBytes));
                //响应
                WebResponse webResponse = webRequest.GetResponse();
                using (StreamReader myStreamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8))
                {
                    //Console.WriteLine(myStreamReader.ReadToEnd());
                    a += myStreamReader.ReadToEnd();
                }
            }




            catch (Exception err)
            {
                return err.ToString();
            }
            return a;

        }
        public string uploadgrade(double fz, string kssj, string scpc = "26256", string bmsqid = "1566615", string bach = "")
        {
            
            StringBuilder soap = new StringBuilder();
            //soap.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            //soap.Append("<soapenv:Envelope xmlns:bean=\"http://bean.webservice.jerry.com\" xmlns:KfItems=\"http://bean.webservice.jerry.com\"  xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:web=\"http://schemas.xmlsoap.org/soap/envelope/\">");
            //soap.Append("<soapenv:Header/>");
            //soap.Append("<soapenv:Body>");
            //soap.Append("<web:uploadSccjAndKfIetmsInfo>");
            //soap.Append("<web:in0>"+username+"</web:in0>");
            //soap.Append("<web:in1>" + pass + "</web:in1>");
            //soap.Append("<web:in2>" + fz + "</web:in2>");          
            //soap.Append("<web:in3>" + kssj+ "</web:in3>");
            //soap.Append("<web:in4>haxd</web:in4>");
            //soap.Append("<web:in5>" + scpc+ "</web:in5>");
            //soap.Append("<web:in6>" + bmsqid+ "</web:in6>");
            //soap.Append("<web:in7>" + bach+ "</web:in7>");
            //soap.Append("<web:in8>0</web:in8>");
            //soap.Append("<web:in9>0</web:in9>");
            //soap.Append("</web:uploadSccjAndKfIetmsInfo>");
            //soap.Append("</soapenv:Body>");
            //soap.Append("</soapenv:Envelope>");

            soap.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?><soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:web=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:bean=\"http://bean.webservice.jerry.com\" xmlns:KfItems=\"http://bean.webservice.jerry.com\" >\r\n\t<soapenv:Header/>\r\n\t<soapenv:Body>\r\n\t\t<web:uploadSccjAndKfIetmsInfo>");
            soap.Append("<web:in0>"+username+"</web:in0>");
            soap.Append("<web:in1>" + pass + "</web:in1>");
            soap.Append("<web:in2>" + fz + "</web:in2>");
            soap.Append("<web:in3>" + kssj+ "</web:in3>");
            soap.Append("<web:in4>haxd</web:in4>");
            soap.Append("<web:in5>" + scpc+ "</web:in5>");
            soap.Append("<web:in6>" + bmsqid+ "</web:in6>");
            soap.Append("<web:in7>" + bach+ "</web:in7>");
          //  soap.Append("<web:in7>0</web:in7>");
            soap.Append("<web:in8>0</web:in8>");
            soap.Append("<web:in9>0</web:in9>");
            soap.Append("</web:uploadSccjAndKfIetmsInfo>");
            soap.Append("</soapenv:Body>");
            soap.Append("</soapenv:Envelope>");


          
            //发起请求
            Uri uri = new Uri(url);
            string a = "";
            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.ContentType = "text/xml; charset=UTF-8";
                webRequest.Method = "POST";
                // webRequest.Headers.Add("SOAPAction", "http://bean.webservice.jerry.com");
                byte[] paramBytes;
                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    paramBytes = Encoding.UTF8.GetBytes(soap.ToString());
                    requestStream.Write(paramBytes, 0, paramBytes.Length);
                }
               MessageBox.Show(soap.ToString());
                //  MessageBox.Show(BitConverter.ToString(paramBytes));
                //响应
                WebResponse webResponse = webRequest.GetResponse();
                using (StreamReader myStreamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8))
                {
                    //Console.WriteLine(myStreamReader.ReadToEnd());
                    a += myStreamReader.ReadToEnd();
                }
                return a;
            }




            catch (Exception err)
            {
                return err.ToString();
            }



        } 
        // 批次下载
        public string queryNjScpc(string lq = "2023-09-04")
        {
            StringBuilder soap = new StringBuilder();
            soap.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            soap.Append("<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:web=\"http://schemas.xmlsoap.org/soap/envelope/\">");
            soap.Append("<soapenv:Header/>");
            soap.Append("<soapenv:Body>");
            soap.Append("<web:queryNjScpc>");
            soap.Append("<web:in0>"+username+"</web:in0>");
            soap.Append("<web:in1>" + pass + "</web:in1>");
            // soap.Append("<web:in2>2023-09-04</web:in2>");
            soap.Append("<web:in2>" + lq+ "</web:in2>");
            soap.Append("</web:queryNjScpc>");
            soap.Append("</soapenv:Body>");
            soap.Append("</soapenv:Envelope>");

            //发起请求
            Uri uri = new Uri(url);
            string a = "";
            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.ContentType = "text/xml; charset=UTF-8";
                webRequest.Method = "POST";
                // webRequest.Headers.Add("SOAPAction", "http://bean.webservice.jerry.com");
                byte[] paramBytes;
                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    paramBytes = Encoding.UTF8.GetBytes(soap.ToString());
                    requestStream.Write(paramBytes, 0, paramBytes.Length);
                }
              //  MessageBox.Show(soap.ToString());
                //  MessageBox.Show(BitConverter.ToString(paramBytes));
                //响应
                WebResponse webResponse = webRequest.GetResponse();
                using (StreamReader myStreamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8))
                {
                    //Console.WriteLine(myStreamReader.ReadToEnd());
                    a += myStreamReader.ReadToEnd();
                }
                return a;
            }




            catch (Exception err)
            {
                return err.ToString();
            }


        }
    }
  

}
