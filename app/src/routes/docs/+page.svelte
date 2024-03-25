<script lang="ts">
	import { onMount } from 'svelte';
	import { page } from '$app/stores';
	import './catppuccin.css';

	let DynamicComponent: any;

	onMount(async () => {
		const script = document.createElement('script');
		script.src = 'https://cdn.jsdelivr.net/npm/@scalar/api-reference';
		script.id = 'api-reference';
		script.dataset.url = `https://${$page.url.hostname}/openapi.json`;
		document.body.appendChild(script);

		const apiReference = document.getElementById('api-reference');

		// Dynamically import the component
		const module = await import('$lib/components/Logo.svelte');
		DynamicComponent = module.default;
	});
</script>

<div>
	<header>
		{#if DynamicComponent}
			<svelte:component this={DynamicComponent} />
		{/if}
	</header>
	<div id="api-reference-container">
		{#if DynamicComponent}
			<svelte:component this={DynamicComponent} />
		{/if}
	</div>
	{#if DynamicComponent}
		<footer>Footer</footer>
	{/if}
</div>

<style lang="css">
</style>
