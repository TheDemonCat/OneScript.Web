﻿/*----------------------------------------------------------
This Source Code Form is subject to the terms of the
Mozilla Public License, v.2.0. If a copy of the MPL
was not distributed with this file, You can obtain one
at http://mozilla.org/MPL/2.0/.
----------------------------------------------------------*/

using ScriptEngine.Machine;

namespace OneScript.WebHost.Infrastructure
{
    public class AnnotationException : RuntimeException
    {
        public AnnotationException(AnnotationDefinition anno, string message) 
            : base($"Неверное применение аннотации {anno.Name}: {message}")
        {
        }
    }
}
