/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OSGeo.OSR {

using System;
using System.Runtime.InteropServices;

class OsrPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("osr_wrap", EntryPoint="SWIGRegisterExceptionCallbacks_Osr")]
    public static extern void SWIGRegisterExceptionCallbacks_Osr(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("osr_wrap", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_Osr")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_Osr(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_Osr(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_Osr(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(OsrPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(OsrPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("osr_wrap", EntryPoint="SWIGRegisterStringCallback_Osr")]
    public static extern void SWIGRegisterStringCallback_Osr(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_Osr(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static OsrPINVOKE() {
  }


  [DllImport("osr_wrap", EntryPoint="CSharp_UseExceptions")]
  public static extern void UseExceptions();

  [DllImport("osr_wrap", EntryPoint="CSharp_DontUseExceptions")]
  public static extern void DontUseExceptions();

  public class StringListMarshal : IDisposable {
    public readonly IntPtr[] _ar;
    public StringListMarshal(string[] ar) {
      _ar = new IntPtr[ar.Length+1];
      for (int cx = 0; cx < ar.Length; cx++) {
	      _ar[cx] = System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(ar[cx]);
      }
      _ar[ar.Length] = IntPtr.Zero;
    }
    public virtual void Dispose() {
	  for (int cx = 0; cx < _ar.Length-1; cx++) {
          System.Runtime.InteropServices.Marshal.FreeHGlobal(_ar[cx]);
      }
      GC.SuppressFinalize(this);
    }
  }


  [DllImport("osr_wrap", EntryPoint="CSharp_StringListDestroy")]
  public static extern void StringListDestroy(IntPtr jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_GetWellKnownGeogCSAsWKT")]
  public static extern int GetWellKnownGeogCSAsWKT(string jarg1, out string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_GetUserInputAsWKT")]
  public static extern int GetUserInputAsWKT(string jarg1, out string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_GetProjectionMethods")]
  public static extern IntPtr GetProjectionMethods();

  [DllImport("osr_wrap", EntryPoint="CSharp_GetProjectionMethodParameterList")]
  public static extern IntPtr GetProjectionMethodParameterList(string jarg1, out string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_GetProjectionMethodParamInfo")]
  public static extern void GetProjectionMethodParamInfo(string jarg1, string jarg2, out string jarg3, out string jarg4, ref double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_new_SpatialReference")]
  public static extern IntPtr new_SpatialReference(string jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_delete_SpatialReference")]
  public static extern void delete_SpatialReference(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference___str__")]
  public static extern string SpatialReference___str__(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsSame")]
  public static extern int SpatialReference_IsSame(HandleRef jarg1, HandleRef jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsSameGeogCS")]
  public static extern int SpatialReference_IsSameGeogCS(HandleRef jarg1, HandleRef jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsSameVertCS")]
  public static extern int SpatialReference_IsSameVertCS(HandleRef jarg1, HandleRef jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsGeographic")]
  public static extern int SpatialReference_IsGeographic(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsProjected")]
  public static extern int SpatialReference_IsProjected(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsCompound")]
  public static extern int SpatialReference_IsCompound(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsGeocentric")]
  public static extern int SpatialReference_IsGeocentric(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsLocal")]
  public static extern int SpatialReference_IsLocal(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_IsVertical")]
  public static extern int SpatialReference_IsVertical(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_EPSGTreatsAsLatLong")]
  public static extern int SpatialReference_EPSGTreatsAsLatLong(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_EPSGTreatsAsNorthingEasting")]
  public static extern int SpatialReference_EPSGTreatsAsNorthingEasting(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetAuthority")]
  public static extern int SpatialReference_SetAuthority(HandleRef jarg1, string jarg2, string jarg3, int jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetAttrValue")]
  public static extern string SpatialReference_GetAttrValue(HandleRef jarg1, string jarg2, int jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetAttrValue")]
  public static extern int SpatialReference_SetAttrValue(HandleRef jarg1, string jarg2, string jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetAngularUnits")]
  public static extern int SpatialReference_SetAngularUnits(HandleRef jarg1, string jarg2, double jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetAngularUnits")]
  public static extern double SpatialReference_GetAngularUnits(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetAngularUnitsName")]
  public static extern string SpatialReference_GetAngularUnitsName(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetTargetLinearUnits")]
  public static extern int SpatialReference_SetTargetLinearUnits(HandleRef jarg1, string jarg2, string jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetLinearUnits")]
  public static extern int SpatialReference_SetLinearUnits(HandleRef jarg1, string jarg2, double jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetLinearUnitsAndUpdateParameters")]
  public static extern int SpatialReference_SetLinearUnitsAndUpdateParameters(HandleRef jarg1, string jarg2, double jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetTargetLinearUnits")]
  public static extern double SpatialReference_GetTargetLinearUnits(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetLinearUnits")]
  public static extern double SpatialReference_GetLinearUnits(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetLinearUnitsName")]
  public static extern string SpatialReference_GetLinearUnitsName(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetAuthorityCode")]
  public static extern string SpatialReference_GetAuthorityCode(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetAuthorityName")]
  public static extern string SpatialReference_GetAuthorityName(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetAxisName")]
  public static extern string SpatialReference_GetAxisName(HandleRef jarg1, string jarg2, int jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetAxisOrientation")]
  public static extern int SpatialReference_GetAxisOrientation(HandleRef jarg1, string jarg2, int jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetUTM")]
  public static extern int SpatialReference_SetUTM(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetUTMZone")]
  public static extern int SpatialReference_GetUTMZone(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetStatePlane")]
  public static extern int SpatialReference_SetStatePlane(HandleRef jarg1, int jarg2, int jarg3, string jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_AutoIdentifyEPSG")]
  public static extern int SpatialReference_AutoIdentifyEPSG(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetProjection")]
  public static extern int SpatialReference_SetProjection(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetProjParm")]
  public static extern int SpatialReference_SetProjParm(HandleRef jarg1, string jarg2, double jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetProjParm")]
  public static extern double SpatialReference_GetProjParm(HandleRef jarg1, string jarg2, double jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetNormProjParm")]
  public static extern int SpatialReference_SetNormProjParm(HandleRef jarg1, string jarg2, double jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetNormProjParm")]
  public static extern double SpatialReference_GetNormProjParm(HandleRef jarg1, string jarg2, double jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetSemiMajor")]
  public static extern double SpatialReference_GetSemiMajor(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetSemiMinor")]
  public static extern double SpatialReference_GetSemiMinor(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetInvFlattening")]
  public static extern double SpatialReference_GetInvFlattening(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetACEA")]
  public static extern int SpatialReference_SetACEA(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetAE")]
  public static extern int SpatialReference_SetAE(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetBonne")]
  public static extern int SpatialReference_SetBonne(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetCEA")]
  public static extern int SpatialReference_SetCEA(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetCS")]
  public static extern int SpatialReference_SetCS(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetEC")]
  public static extern int SpatialReference_SetEC(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetEckertIV")]
  public static extern int SpatialReference_SetEckertIV(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetEckertVI")]
  public static extern int SpatialReference_SetEckertVI(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetEquirectangular")]
  public static extern int SpatialReference_SetEquirectangular(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetEquirectangular2")]
  public static extern int SpatialReference_SetEquirectangular2(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetGaussSchreiberTMercator")]
  public static extern int SpatialReference_SetGaussSchreiberTMercator(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetGS")]
  public static extern int SpatialReference_SetGS(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetGH")]
  public static extern int SpatialReference_SetGH(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetIGH")]
  public static extern int SpatialReference_SetIGH(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetGEOS")]
  public static extern int SpatialReference_SetGEOS(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetGnomonic")]
  public static extern int SpatialReference_SetGnomonic(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetHOM")]
  public static extern int SpatialReference_SetHOM(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetHOM2PNO")]
  public static extern int SpatialReference_SetHOM2PNO(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8, double jarg9);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetKrovak")]
  public static extern int SpatialReference_SetKrovak(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetLAEA")]
  public static extern int SpatialReference_SetLAEA(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetLCC")]
  public static extern int SpatialReference_SetLCC(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetLCC1SP")]
  public static extern int SpatialReference_SetLCC1SP(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetLCCB")]
  public static extern int SpatialReference_SetLCCB(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetMC")]
  public static extern int SpatialReference_SetMC(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetMercator")]
  public static extern int SpatialReference_SetMercator(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetMercator2SP")]
  public static extern int SpatialReference_SetMercator2SP(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetMollweide")]
  public static extern int SpatialReference_SetMollweide(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetNZMG")]
  public static extern int SpatialReference_SetNZMG(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetOS")]
  public static extern int SpatialReference_SetOS(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetOrthographic")]
  public static extern int SpatialReference_SetOrthographic(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetPolyconic")]
  public static extern int SpatialReference_SetPolyconic(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetPS")]
  public static extern int SpatialReference_SetPS(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetRobinson")]
  public static extern int SpatialReference_SetRobinson(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetSinusoidal")]
  public static extern int SpatialReference_SetSinusoidal(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetStereographic")]
  public static extern int SpatialReference_SetStereographic(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetSOC")]
  public static extern int SpatialReference_SetSOC(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetTM")]
  public static extern int SpatialReference_SetTM(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetTMVariant")]
  public static extern int SpatialReference_SetTMVariant(HandleRef jarg1, string jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetTMG")]
  public static extern int SpatialReference_SetTMG(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetTMSO")]
  public static extern int SpatialReference_SetTMSO(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetVDG")]
  public static extern int SpatialReference_SetVDG(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetWellKnownGeogCS")]
  public static extern int SpatialReference_SetWellKnownGeogCS(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetFromUserInput")]
  public static extern int SpatialReference_SetFromUserInput(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_CopyGeogCSFrom")]
  public static extern int SpatialReference_CopyGeogCSFrom(HandleRef jarg1, HandleRef jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetTOWGS84")]
  public static extern int SpatialReference_SetTOWGS84(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_GetTOWGS84")]
  public static extern int SpatialReference_GetTOWGS84(HandleRef jarg1, double[] jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetLocalCS")]
  public static extern int SpatialReference_SetLocalCS(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetGeogCS")]
  public static extern int SpatialReference_SetGeogCS(HandleRef jarg1, string jarg2, string jarg3, string jarg4, double jarg5, double jarg6, string jarg7, double jarg8, string jarg9, double jarg10);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetProjCS")]
  public static extern int SpatialReference_SetProjCS(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetGeocCS")]
  public static extern int SpatialReference_SetGeocCS(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetVertCS")]
  public static extern int SpatialReference_SetVertCS(HandleRef jarg1, string jarg2, string jarg3, int jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_SetCompoundCS")]
  public static extern int SpatialReference_SetCompoundCS(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromWkt")]
  public static extern int SpatialReference_ImportFromWkt(HandleRef jarg1, ref string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromProj4")]
  public static extern int SpatialReference_ImportFromProj4(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromUrl")]
  public static extern int SpatialReference_ImportFromUrl(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromESRI")]
  public static extern int SpatialReference_ImportFromESRI(HandleRef jarg1, IntPtr[] jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromEPSG")]
  public static extern int SpatialReference_ImportFromEPSG(HandleRef jarg1, int jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromEPSGA")]
  public static extern int SpatialReference_ImportFromEPSGA(HandleRef jarg1, int jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromPCI")]
  public static extern int SpatialReference_ImportFromPCI(HandleRef jarg1, string jarg2, string jarg3, double[] jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromUSGS")]
  public static extern int SpatialReference_ImportFromUSGS(HandleRef jarg1, int jarg2, int jarg3, double[] jarg4, int jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromXML")]
  public static extern int SpatialReference_ImportFromXML(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromERM")]
  public static extern int SpatialReference_ImportFromERM(HandleRef jarg1, string jarg2, string jarg3, string jarg4);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromMICoordSys")]
  public static extern int SpatialReference_ImportFromMICoordSys(HandleRef jarg1, string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ImportFromOzi")]
  public static extern int SpatialReference_ImportFromOzi(HandleRef jarg1, IntPtr[] jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ExportToWkt")]
  public static extern int SpatialReference_ExportToWkt(HandleRef jarg1, out string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ExportToPrettyWkt")]
  public static extern int SpatialReference_ExportToPrettyWkt(HandleRef jarg1, out string jarg2, int jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ExportToProj4")]
  public static extern int SpatialReference_ExportToProj4(HandleRef jarg1, out string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ExportToPCI")]
  public static extern int SpatialReference_ExportToPCI(HandleRef jarg1, out string jarg2, out string jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ExportToUSGS")]
  public static extern int SpatialReference_ExportToUSGS(HandleRef jarg1, out int jarg2, out int jarg3, out int jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ExportToXML")]
  public static extern int SpatialReference_ExportToXML(HandleRef jarg1, out string jarg2, string jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ExportToMICoordSys")]
  public static extern int SpatialReference_ExportToMICoordSys(HandleRef jarg1, out string jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_CloneGeogCS")]
  public static extern IntPtr SpatialReference_CloneGeogCS(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_Clone")]
  public static extern IntPtr SpatialReference_Clone(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_Validate")]
  public static extern int SpatialReference_Validate(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_StripCTParms")]
  public static extern int SpatialReference_StripCTParms(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_FixupOrdering")]
  public static extern int SpatialReference_FixupOrdering(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_Fixup")]
  public static extern int SpatialReference_Fixup(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_MorphToESRI")]
  public static extern int SpatialReference_MorphToESRI(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_MorphFromESRI")]
  public static extern int SpatialReference_MorphFromESRI(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_SpatialReference_ConvertToOtherProjection")]
  public static extern IntPtr SpatialReference_ConvertToOtherProjection(HandleRef jarg1, string jarg2, IntPtr[] jarg3);

  [DllImport("osr_wrap", EntryPoint="CSharp_new_CoordinateTransformation")]
  public static extern IntPtr new_CoordinateTransformation(HandleRef jarg1, HandleRef jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_delete_CoordinateTransformation")]
  public static extern void delete_CoordinateTransformation(HandleRef jarg1);

  [DllImport("osr_wrap", EntryPoint="CSharp_CoordinateTransformation_TransformPoint__SWIG_0")]
  public static extern void CoordinateTransformation_TransformPoint__SWIG_0(HandleRef jarg1, double[] jarg2);

  [DllImport("osr_wrap", EntryPoint="CSharp_CoordinateTransformation_TransformPoint__SWIG_1")]
  public static extern void CoordinateTransformation_TransformPoint__SWIG_1(HandleRef jarg1, double[] jarg2, double jarg3, double jarg4, double jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_CoordinateTransformation_TransformPoints")]
  public static extern void CoordinateTransformation_TransformPoints(HandleRef jarg1, int jarg2, double[] jarg3, double[] jarg4, double[] jarg5);

  [DllImport("osr_wrap", EntryPoint="CSharp_CreateCoordinateTransformation")]
  public static extern IntPtr CreateCoordinateTransformation(HandleRef jarg1, HandleRef jarg2);
}

}
