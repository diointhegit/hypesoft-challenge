import ProfileButton from "./Profile-Button";

export default function Topnav() {
  return (
    <nav className="flex justify-between h-16 border-2 items-center outline-black w-screen">
      {" "}
      <p>Hypesoftstore</p> <ProfileButton />
    </nav>
  );
}
