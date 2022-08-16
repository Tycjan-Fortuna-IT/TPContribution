﻿//TODO CI Inter Layers Communication - Add Initial Stuff #239
//__________________________________________________________________________________________
//
//  Copyright 2022 Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the `Watch` button and to get started
//  comment using the discussion panel at
//  https://github.com/mpostol/TP/discussions/182
//  with an introduction of yourself and tell us about what you do with this community.
//__________________________________________________________________________________________

namespace TP.InformationComputation.LayersCommunication.Logic
{
  public interface ICallBack
  {
    void Alpha(TraceDataDelegate trace);

    void Bravo(TraceDataDelegate trace);

    void Charlie(TraceDataDelegate trace);

    void Delta(TraceDataDelegate trace);
  }
}