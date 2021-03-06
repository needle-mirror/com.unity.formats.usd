//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class UsdGeomConstraintTarget : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdGeomConstraintTarget(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomConstraintTarget obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdGeomConstraintTarget()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_UsdGeomConstraintTarget(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public UsdGeomConstraintTarget() : this(UsdCsPINVOKE.new_UsdGeomConstraintTarget__SWIG_0(), true)
        {
        }

        public UsdGeomConstraintTarget(UsdAttribute attr) : this(UsdCsPINVOKE.new_UsdGeomConstraintTarget__SWIG_1(UsdAttribute.getCPtr(attr)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static bool IsValid(UsdAttribute attr)
        {
            bool ret = UsdCsPINVOKE.UsdGeomConstraintTarget_IsValid(UsdAttribute.getCPtr(attr));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public UsdAttribute GetAttr()
        {
            UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdGeomConstraintTarget_GetAttr(swigCPtr), false);
            return ret;
        }

        public bool IsDefined()
        {
            bool ret = UsdCsPINVOKE.UsdGeomConstraintTarget_IsDefined(swigCPtr);
            return ret;
        }

        public bool Get(GfMatrix4d value, UsdTimeCode time)
        {
            bool ret = UsdCsPINVOKE.UsdGeomConstraintTarget_Get__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(value), UsdTimeCode.getCPtr(time));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Get(GfMatrix4d value)
        {
            bool ret = UsdCsPINVOKE.UsdGeomConstraintTarget_Get__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(value));
            return ret;
        }

        public bool Set(GfMatrix4d value, UsdTimeCode time)
        {
            bool ret = UsdCsPINVOKE.UsdGeomConstraintTarget_Set__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(value), UsdTimeCode.getCPtr(time));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public bool Set(GfMatrix4d value)
        {
            bool ret = UsdCsPINVOKE.UsdGeomConstraintTarget_Set__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(value));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public TfToken GetIdentifier()
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomConstraintTarget_GetIdentifier(swigCPtr), true);
            return ret;
        }

        public void SetIdentifier(TfToken identifier)
        {
            UsdCsPINVOKE.UsdGeomConstraintTarget_SetIdentifier(swigCPtr, TfToken.getCPtr(identifier));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static TfToken GetConstraintAttrName(string constraintName)
        {
            TfToken ret = new TfToken(UsdCsPINVOKE.UsdGeomConstraintTarget_GetConstraintAttrName(constraintName), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public GfMatrix4d ComputeInWorldSpace(UsdTimeCode time, UsdGeomXformCache xfCache)
        {
            GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time), UsdGeomXformCache.getCPtr(xfCache)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public GfMatrix4d ComputeInWorldSpace(UsdTimeCode time)
        {
            GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_1(swigCPtr, UsdTimeCode.getCPtr(time)), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public GfMatrix4d ComputeInWorldSpace()
        {
            GfMatrix4d ret = new GfMatrix4d(UsdCsPINVOKE.UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_2(swigCPtr), true);
            return ret;
        }
    }
}
