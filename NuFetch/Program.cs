﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuFetch {
    class Program {
        static void Main( string[] args ) {
        }

        static async Task MainAsync(string[] args) {
            await Task.Run( () => { } );
        }
    }
}
