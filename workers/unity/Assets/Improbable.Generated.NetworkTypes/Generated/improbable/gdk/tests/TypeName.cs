// Generated by SpatialOS codegen. DO NOT EDIT!
// source: improbable.gdk.tests.TypeName in improbable/gdk/tests/nested_typenames.schema.

namespace Improbable.Gdk.Tests
{

public partial struct TypeName : global::System.IEquatable<TypeName>, global::Improbable.Collections.IDeepCopyable<TypeName>
{
  /// <summary>
  /// Field other_type = 1.
  /// </summary>
  public global::Improbable.Gdk.Tests.TypeName.Other otherType;

  public TypeName(global::Improbable.Gdk.Tests.TypeName.Other otherType)
  {
    this.otherType = otherType;
  }

  public static TypeName Create()
  {
    var _result = new TypeName();
    _result.otherType = global::Improbable.Gdk.Tests.TypeName.Other.Create();
    return _result;
  }

  public TypeName DeepCopy()
  {
    var _result = new TypeName();
    _result.otherType = otherType.DeepCopy();
    return _result;

  }

  public override bool Equals(object _obj)
  {
    return _obj is TypeName && Equals((TypeName) _obj);
  }

  public static bool operator==(TypeName a, TypeName b)
  {
    return a.Equals(b);
  }

  public static bool operator!=(TypeName a, TypeName b)
  {
    return !a.Equals(b);
  }

  public bool Equals(TypeName _obj)
  {
    return
        otherType == _obj.otherType;
  }

  public override int GetHashCode()
  {
    int _result = 1327;
    _result = (_result * 977) + otherType.GetHashCode();
    return _result;
  }

  public partial struct Other : global::System.IEquatable<Other>, global::Improbable.Collections.IDeepCopyable<Other>
  {
    /// <summary>
    /// Field same_name = 1.
    /// </summary>
    public global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName sameName;

    public Other(global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName sameName)
    {
      this.sameName = sameName;
    }

    public static Other Create()
    {
      var _result = new Other();
      _result.sameName = global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.Create();
      return _result;
    }

    public Other DeepCopy()
    {
      var _result = new Other();
      _result.sameName = sameName.DeepCopy();
      return _result;

    }

    public override bool Equals(object _obj)
    {
      return _obj is Other && Equals((Other) _obj);
    }

    public static bool operator==(Other a, Other b)
    {
      return a.Equals(b);
    }

    public static bool operator!=(Other a, Other b)
    {
      return !a.Equals(b);
    }

    public bool Equals(Other _obj)
    {
      return
          sameName == _obj.sameName;
    }

    public override int GetHashCode()
    {
      int _result = 1327;
      _result = (_result * 977) + sameName.GetHashCode();
      return _result;
    }

    public partial struct NestedTypeName : global::System.IEquatable<NestedTypeName>, global::Improbable.Collections.IDeepCopyable<NestedTypeName>
    {
      /// <summary>
      /// Field other_zero = 1.
      /// </summary>
      public global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.Other0 otherZero;
      /// <summary>
      /// Field enum_field = 2.
      /// </summary>
      public global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.NestedEnum enumField;

      public NestedTypeName(
          global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.Other0 otherZero,
          global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.NestedEnum enumField)
      {
        this.otherZero = otherZero;
        this.enumField = enumField;
      }

      public static NestedTypeName Create()
      {
        var _result = new NestedTypeName();
        _result.otherZero = global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.Other0.Create();
        _result.enumField = global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.NestedEnum.enum_value;
        return _result;
      }

      public NestedTypeName DeepCopy()
      {
        var _result = new NestedTypeName();
        _result.otherZero = otherZero.DeepCopy();
        _result.enumField = enumField;
        return _result;

      }

      public override bool Equals(object _obj)
      {
        return _obj is NestedTypeName && Equals((NestedTypeName) _obj);
      }

      public static bool operator==(NestedTypeName a, NestedTypeName b)
      {
        return a.Equals(b);
      }

      public static bool operator!=(NestedTypeName a, NestedTypeName b)
      {
        return !a.Equals(b);
      }

      public bool Equals(NestedTypeName _obj)
      {
        return
            otherZero == _obj.otherZero &&
            enumField == _obj.enumField;
      }

      public override int GetHashCode()
      {
        int _result = 1327;
        _result = (_result * 977) + otherZero.GetHashCode();
        _result = (_result * 977) + enumField.GetHashCode();
        return _result;
      }

      public enum NestedEnum : uint
      {
        enum_value = 1
      }

      public partial struct Other0 : global::System.IEquatable<Other0>, global::Improbable.Collections.IDeepCopyable<Other0>
      {
        /// <summary>
        /// Field foo = 1.
        /// </summary>
        public int foo;

        public Other0(int foo)
        {
          this.foo = foo;
        }

        public static Other0 Create()
        {
          var _result = new Other0();
          return _result;
        }

        public Other0 DeepCopy()
        {
          var _result = new Other0();
          _result.foo = foo;
          return _result;

        }

        public override bool Equals(object _obj)
        {
          return _obj is Other0 && Equals((Other0) _obj);
        }

        public static bool operator==(Other0 a, Other0 b)
        {
          return a.Equals(b);
        }

        public static bool operator!=(Other0 a, Other0 b)
        {
          return !a.Equals(b);
        }

        public bool Equals(Other0 _obj)
        {
          return
              foo == _obj.foo;
        }

        public override int GetHashCode()
        {
          int _result = 1327;
          _result = (_result * 977) + foo.GetHashCode();
          return _result;
        }
      }

      public static class Other0_Internal
      {
        public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                        Other0 _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
        {
          {
            global::Improbable.Worker.Internal.Pbio.AddInt32(_obj, 1, _data.foo);
          }
        }

        public static unsafe Other0 Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
        {
          Other0 _data;
          {
            _data.foo = global::Improbable.Worker.Internal.Pbio.GetInt32(_obj, 1);
          }
          return _data;
        }
      }

    }

    public static class NestedTypeName_Internal
    {
      public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                      NestedTypeName _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
      {
        {
          global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.Other0_Internal.Write(_pool, _data.otherZero, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
        }
        {
          global::Improbable.Worker.Internal.Pbio.AddUint32(_obj, 2, (uint) _data.enumField);
        }
      }

      public static unsafe NestedTypeName Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
      {
        NestedTypeName _data;
        {
          _data.otherZero = global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.Other0_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
        }
        {
          _data.enumField = (global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName.NestedEnum) global::Improbable.Worker.Internal.Pbio.GetUint32(_obj, 2);
        }
        return _data;
      }
    }

  }

  public static class Other_Internal
  {
    public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                    Other _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      {
        global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName_Internal.Write(_pool, _data.sameName, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
      }
    }

    public static unsafe Other Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
    {
      Other _data;
      {
        _data.sameName = global::Improbable.Gdk.Tests.TypeName.Other.NestedTypeName_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
      }
      return _data;
    }
  }

}

public static class TypeName_Internal
{
  public static unsafe void Write(global::Improbable.Worker.Internal.GcHandlePool _pool,
                                  TypeName _data, global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    {
      global::Improbable.Gdk.Tests.TypeName.Other_Internal.Write(_pool, _data.otherType, global::Improbable.Worker.Internal.Pbio.AddObject(_obj, 1));
    }
  }

  public static unsafe TypeName Read(global::Improbable.Worker.Internal.Pbio.Object* _obj)
  {
    TypeName _data;
    {
      _data.otherType = global::Improbable.Gdk.Tests.TypeName.Other_Internal.Read(global::Improbable.Worker.Internal.Pbio.GetObject(_obj, 1));
    }
    return _data;
  }
}

}