﻿//======================================================================
//        Copyright (C) 2015-2020 Winddy He. All rights reserved
//        Email: hgplan@126.com
//======================================================================
using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Framework.Hotfix
{
    [System.Serializable]
    public class MonoBehaviourProxy
    {
        public List<UnityObject>    Objects;
        public List<BaseDataObject> BaseDatas;

        public virtual void SetObjects(List<UnityObject> rObjs, List<BaseDataObject> rBaseDatas)
        {
            this.Objects = rObjs;
            this.BaseDatas = rBaseDatas;
        } 

        public virtual void Awake()
        {
        }

        public virtual void Start()
        {
        }

        public virtual void Update()
        {
        }

        public virtual void OnDestroy()
        {
        }

        public virtual void OnEnable()
        {
        }

        public virtual void OnDisable()
        {
        }

        public virtual void OnUnityEvent(Object rTarget)
        {
        }

        public object GetData(string rName)
        {
            if (this.BaseDatas == null) return null;
            var rBaseDataObj = this.BaseDatas.Find((rItem) => { return rItem.Name.Equals(rName); });
            if (rBaseDataObj == null) return null;
            return rBaseDataObj.Object;
        }
    }
}