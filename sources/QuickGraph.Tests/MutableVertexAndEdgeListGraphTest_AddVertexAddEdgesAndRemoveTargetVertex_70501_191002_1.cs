using System.CodeDom.Compiler;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.CodeDom;
using QuickGraph.Unit;

namespace QuickGraph
{
    
    
    public partial class MutableVertexAndEdgeListGraphTest
    {
        
        /// <summary>
        ///  Test generated by Pex
        ///</summary>
        ///<exception cref="System.ArgumentNullException">
        ///  Value cannot be null.
        ///Parameter name: v
        ///</exception>
        [QuickGraph.Unit.TestAttribute()]
        [QuickGraph.Unit.ExpectedArgumentNullExceptionAttribute()]
        [PexGeneratedBy(typeof(QuickGraph.MutableVertexAndEdgeListGraphTest), "MutableVertexAndEdgeListGraphTest.AddVertexAddEdgesAndRemoveTargetVertex(IMutable" +
            "VertexAndEdgeListGraph<String,Edge<String>>, String, String)")]
        [GeneratedCode("Pex", "1.1.20430.1")]
        public void AddVertexAddEdgesAndRemoveTargetVertex_IMutableVertexAndEdgeListGraph2_String_String_70501_191002_0_01()
        {
            QuickGraph.AdjacencyGraph<string, QuickGraph.Edge<string>> ag0 = new QuickGraph.AdjacencyGraph<string, QuickGraph.Edge<string>>(false);
            this.AddVertexAddEdgesAndRemoveTargetVertex(((QuickGraph.IMutableVertexAndEdgeListGraph<string, QuickGraph.Edge<string>>)(ag0)), ((string)(null)), ((string)(null)));
        }
        
        /// <summary>
        ///  Test generated by Pex
        ///</summary>
        ///<exception cref="System.ArgumentNullException">
        ///  Value cannot be null.
        ///Parameter name: v
        ///</exception>
        [QuickGraph.Unit.TestAttribute()]
        [QuickGraph.Unit.ExpectedArgumentNullExceptionAttribute()]
        [PexGeneratedBy(typeof(QuickGraph.MutableVertexAndEdgeListGraphTest), "MutableVertexAndEdgeListGraphTest.AddVertexAddEdgesAndRemoveTargetVertex(IMutable" +
            "VertexAndEdgeListGraph<String,Edge<String>>, String, String)")]
        [GeneratedCode("Pex", "1.1.20430.1")]
        public void AddVertexAddEdgesAndRemoveTargetVertex_IMutableVertexAndEdgeListGraph2_String_String_70501_191002_0_02()
        {
            QuickGraph.AdjacencyGraph<string, QuickGraph.Edge<string>> ag0 = new QuickGraph.AdjacencyGraph<string, QuickGraph.Edge<string>>(false);
            string s0 = "";
            this.AddVertexAddEdgesAndRemoveTargetVertex(((QuickGraph.IMutableVertexAndEdgeListGraph<string, QuickGraph.Edge<string>>)(ag0)), ((string)(s0)), ((string)(null)));
        }
        
        /// <summary>
        ///  Test generated by Pex
        ///</summary>
        ///<exception cref="System.ArgumentException">
        ///  vertex already in graph
        ///Parameter name: v
        ///</exception>
        [QuickGraph.Unit.TestAttribute()]
        [QuickGraph.Unit.ExpectedArgumentExceptionAttribute()]
        [PexGeneratedBy(typeof(QuickGraph.MutableVertexAndEdgeListGraphTest), "MutableVertexAndEdgeListGraphTest.AddVertexAddEdgesAndRemoveTargetVertex(IMutable" +
            "VertexAndEdgeListGraph<String,Edge<String>>, String, String)")]
        [GeneratedCode("Pex", "1.1.20430.1")]
        public void AddVertexAddEdgesAndRemoveTargetVertex_IMutableVertexAndEdgeListGraph2_String_String_70501_191002_0_03()
        {
            QuickGraph.AdjacencyGraph<string, QuickGraph.Edge<string>> ag0 = new QuickGraph.AdjacencyGraph<string, QuickGraph.Edge<string>>(false);
            string s0 = "";
            this.AddVertexAddEdgesAndRemoveTargetVertex(((QuickGraph.IMutableVertexAndEdgeListGraph<string, QuickGraph.Edge<string>>)(ag0)), ((string)(s0)), ((string)(s0)));
        }
    }
}
