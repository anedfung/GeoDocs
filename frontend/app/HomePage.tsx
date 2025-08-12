"use client";

import dynamic from "next/dynamic";
import { useMemo } from "react";

const MapChart = dynamic(() => import("./components/MapChart"), {
  ssr: false, // Important! Disable server-side rendering for this client-only map
  loading: () => <p>Loading map...</p>
});

export default function HomePage() {

  return <div>
    <MapChart position={[9.96692, -84.119598]} zoom={13} />
  </div>
}
