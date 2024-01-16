using System;
using System.Collections.Generic;
using SimpleJson;

namespace Specification.Scene
{
    [Serializable]
    public class SceneSpecification : Specification
    {
        public string SceneId;
        public string PrefabId;
        
        public override void Fill(IDictionary<string, object> node)
        {
            _id = node.GetString("id");
            SceneId = node.GetString("scene_id");
            PrefabId = node.GetString("prefab_id");
        }
    }
}