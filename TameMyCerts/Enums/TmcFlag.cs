﻿using System;

namespace TameMyCerts.Enums;

/// <summary>
///     Flags that control global behavior of TameMyCerts.
/// </summary>
[Flags]
public enum TmcFlag : uint
{
    /// <summary>
    ///     Defaults to denying certificate requests if there is no policy defined for the certificate template.
    /// </summary>
    TMC_DENY_IF_NO_POLICY = 0x1,

    /// <summary>
    ///     Does not deny certificate requests if EDITF_ATTRIBUTESUBJECTALTNAME2 is abused. Use with caution.
    /// </summary>
    TMC_WARN_ONLY_ON_INSECURE_FLAGS = 0x2,

    /// <summary>
    ///     Causes Directory Service Validator to not perform nested group searching, which may come at the cost of additional load
    ///     on Domain Controllers. Also, all Domain Controllers must be Windows Server 2016 or newer for revolving of nested group memberships to work.
    /// </summary>
    TMC_DONT_RESOLVE_NESTED_GROUP_MEMBERSHIPS = 0x4,


    /// <summary>
    ///     Defaults to denying certificate requests if the policy directory does not exist.
    /// </summary>
    TMC_DENY_IF_NO_POLICY_DIR = 0x8
}