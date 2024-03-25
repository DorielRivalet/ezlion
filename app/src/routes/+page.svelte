<script lang="ts">
	import Logo from '$lib/components/Logo.svelte';
	import './styles.css';
</script>

<main>
	<h1>EZlion</h1>
	<Logo />
	<p class="slogan">Data retrieval, made easy</p>
	<h2>API Reference</h2>
	<p>See <a data-sveltekit-reload href="./docs">here</a> for the API reference</p>
</main>
<footer>
	Powered by SvelteKit. Visit <a href="https://kit.svelte.dev">kit.svelte.dev</a> to read the documentation.
</footer>

<style type="text/css">
	.slogan {
		font-style: italic;
	}
</style>
