; guix environment --manifest=dotnet.scm
( specifications->manifest
 '( "make"
    "texlive"
    "emacs-graphviz-dot-mode"
    "dot2tex"
    "texlive-pstool"
    "graphviz"
    "dotnet"
    "ocaml"
  )
)
