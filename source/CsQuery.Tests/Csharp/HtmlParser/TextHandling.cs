﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using CollectionAssert = NUnit.Framework.CollectionAssert;
using Description = NUnit.Framework.DescriptionAttribute;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;
using CsQuery;
using CsQuery.HtmlParser;
using CsQuery.Utility;

namespace CsQuery.Tests.Csharp.HtmlParser
{

    [TestFixture, TestClass]
    public class TextHandling : CsQueryTest
    {

        [Test, TestMethod]
        public void TextOnly()
        {
            string html = "a<b";
            var dom = CQ.Create(html);
            Assert.AreEqual("a", dom.Render());

            html = "a < b";
            dom = CQ.Create(html);
            Assert.AreEqual("a < b", dom.Render(DomRenderingOptions.HtmlEncodingNone));
        }

        [Test,TestMethod]
        public void TextOnly2()
        {
            string html = "a < bsdf <>";
            var cs = CsQuery.CQ.Create(html);

            Assert.AreEqual("a &lt; bsdf &lt;&gt;", cs.Render());
            Assert.AreEqual("a &lt; bsdf &lt;&gt;", cs.Render(CsQuery.DomRenderingOptions.HtmlEncodingMinimum));
        }
    }
}
