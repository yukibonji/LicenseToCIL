﻿namespace LicenseToCIL
open LicenseToCIL.Stack
open System
open System.Reflection
open System.Reflection.Emit

type Op<'stackin, 'stackout> = S<'stackin> -> IL -> S<'stackout>
